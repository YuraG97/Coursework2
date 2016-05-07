using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class RoadOnRoute : DataBase<RoadOnRoute>
    {
        public Guid RoadGuid { get; set; }
        public Guid RouteGuid { get; set; }

        public RoadOnRoute() { }

        [XmlIgnore]
        public Road Road
        {
            get { return Road.Items[RoadGuid]; }
            set { RoadGuid = value.Id; }
        }
        [XmlIgnore]
        public Route Route
        {
            get { return Route.Items[RouteGuid]; }
            set { RouteGuid = value.Id; }
        }

        public RoadOnRoute(Road road, Route route)
        {
            Road = road;
            Route = route;
        }

        public static void Serialize()
        {
            string fileName = "RoadOnRoute.xml";
            RoadOnRoute[] stopsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(RoadOnRoute[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, stopsArr);
            }
        }
    }
}