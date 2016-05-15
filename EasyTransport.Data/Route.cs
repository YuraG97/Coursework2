using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Route : DataBase<Route>
    {
        public Route() { }

        [XmlIgnore]
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

        [XmlIgnore]
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

        [XmlIgnore]
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

#region Serialize And Deserialize 
        public static void Deserialize()
        {
            string fileName = "Route.xml";
            Deserialize(fileName);
        }

        public static void Serialize()
        {
            string fileName = "Route.xml";
            Serialize(fileName);
        }
#endregion

    }
}