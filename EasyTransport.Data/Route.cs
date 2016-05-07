using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Route : DataBase<Route>
    {
        public Route() { }

        public List<Road> Roads
        {
            get
            {
                var res = new List<Road>();
                foreach (var roadOnRoute in RoadOnRoute.Items.Values)
                {
                    if (roadOnRoute.Route == this)
                    {
                        res.Add(roadOnRoute.Road);
                    }
                }
                return res;
            }
        }

        public List<Trip> Trips
        {
            get
            {
                var res = new List<Trip>();
                foreach (var trip in Trip.Items.Values)
                {
                    if (trip.Route == this)
                    {
                        res.Add(trip);
                    }
                }
                return res;
            }
        }

        public List<Transport> Transports
        {
            get
            {
                var res = new List<Transport>();
                foreach (var trip in Trip.Items.Values)
                {
                    if (trip.Route == this)
                    {
                        res.Add(trip.Transport);
                    }
                }
                return res;
            }
        }

        public static void Serialize()
        {
            string fileName = "Route.xml";
            Route[] roadsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(Route[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, roadsArr);
            }
        }
    }
}