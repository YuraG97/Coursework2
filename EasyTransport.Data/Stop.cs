using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Stop : DataBase<Stop>
    {
        public string Name { get; set; }
        public TransportType StopTransportType { get; set; }
        public PointF Coordinates { get; set; }
        public List<string> Comments { get; set; }

        public Stop() { }

        public Stop(TransportType trType, decimal x, decimal y, string name)
        {
            StopTransportType = trType;
            Coordinates = new PointF((float) x, (float) y);
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} - id#{Id.ToString("N")}";
        }

        [XmlIgnore]
        public List<Road> Roads
        {
            get
            {
                var res = new List<Road>();
                foreach (var road in Road.Items.Values)
                {
                    if (road.Stop1 == this || road.Stop2 == this)
                    {
                        res.Add(road);
                    }
                }
                return res;
            }
        }

        [XmlIgnore]
        public List<Stop> NearStops
        {
            get
            {
                var res = new List<Stop>();
                foreach (var road in Road.Items.Values)
                {
                    if (road.RoadTransportType != TransportType.Walk)
                    {
                        if (road.Stop1 == this)
                        {
                            res.Add(road.Stop2);
                        }
                        else if (road.Stop2 == this && road.IsTwoDir)
                        {
                            res.Add(road.Stop1);
                        }
                    }
                }
                return res;
            }
        }

        #region Serialize And Deserialize
        public static void Deserialize()
        {
            string fileName = "Stop.xml";
            Deserialize(fileName);
        }

        public static void Serialize()
        {
            string fileName = "Stop.xml";
            Serialize(fileName);
        }
#endregion
    }
}