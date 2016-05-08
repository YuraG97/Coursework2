using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Road : DataBase<Road>
    {
        public Guid Stop1Id { get; set; }
        public Guid Stop2Id { get; set; }

        public int Length { get; set; }
        public List<string> Comments { get; set; }
        public string Description { get; set; }
        public QualityType Quality { get; set; }
        public TransportType RoadTransportType { get; set; }
        public double AverageSpeed { get; set; }
        public double BadWeaterSpeed { get; set; }

        public Road() { }

        public Road(Stop stop1, Stop stop2)
        {
            Stop1 = stop1;
            Stop2 = stop2;
        }

        [XmlIgnore]
        public Stop Stop1
        {
            get { return Stop.Items[Stop1Id]; }
            set { Stop1Id = value.Id; }
        }

        [XmlIgnore]
        public Stop Stop2
        {
            get { return Stop.Items[Stop2Id]; }
            set { Stop2Id = value.Id; }
        }
        [XmlIgnore]
        public List<Route> Routes
        {
            get
            {
                var res = new List<Route>();
                foreach (var roadOnRoute in RoadOnRoute.Items.Values)
                {
                    if (roadOnRoute.Road == this)
                    {
                        res.Add(roadOnRoute.Route);
                    }
                }
                return res;
            }
        }
        public static void Deserialize()
        {
            string fileName = "Road.xml";
            Deserialize(fileName);
        }

        public static void Serialize()
        {
            string fileName = "Road.xml";
            Serialize(fileName);
        }
    }
}