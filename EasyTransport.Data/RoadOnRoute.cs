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
        private Guid _road;
        private Guid _route;

        public RoadOnRoute() { }
        public Road Road
        {
            get { return Road.Items[_road]; }
            set { _road = value.Id; }
        }

        public Route Route
        {
            get { return Route.Items[_route]; }
            set { _route = value.Id; }
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