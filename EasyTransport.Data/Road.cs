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
        private Guid _stop1Id;
        private Guid _stop2Id;

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

        public Stop Stop1
        {
            get { return Stop.Items[_stop1Id]; }
            set { _stop1Id = value.Id; }
        }

        public Stop Stop2
        {
            get { return Stop.Items[_stop2Id]; }
            set { _stop2Id = value.Id; }
        }

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

        public static void Serialize()
        {
            string fileName = "Road.xml";
            Road[] roadsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(Road[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, roadsArr);
            }
        }
    }
}