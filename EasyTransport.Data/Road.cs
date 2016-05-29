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
        public double Length { get; set; }
        public bool IsTwoDir { get; set; }
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
        public Road(Stop stop1, Stop stop2, bool twoDir, double length, TransportType trType, QualityType quality)
        {
            Stop1 = stop1;
            Stop2 = stop2;
            IsTwoDir = twoDir;
            Length = length;
            RoadTransportType = trType;
            Quality = quality;
        }

        public static Road GetRoadByStops(Stop stop1, Stop stop2)
        {
            foreach (var item in Items.Values)
            {
                if ((item.Stop1 == stop1 && item.Stop2 == stop2)||(item.Stop2 == stop1 && item.Stop1 == stop2))
                {
                    return item;
                }
            }
            return null;
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

        public override string ToString()
        {
            string res = string.Format("{0,-12}-{1,-12}-{2,-12}-{3}", Stop1.Name, Stop2.Name, RoadTransportType, Id.ToString("N"));
            return res;
        }

        #region Serialize And Deserialize
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
#endregion

    }
}