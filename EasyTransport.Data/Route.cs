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
        public Guid StopStartId { get; set; }
        public Guid StopStartInvDirId { get; set; }
        public TransportType RouteTransportType { get; set; }
        public string Name { get; set; }
        public double TicketCost { get; set; }
        public Route() { }

        public void AddRoadOnRoute(Road road, bool dir)
        {
            new RoadOnRoute(road, this, dir);
        }
        public void AddStopOnRoute(Stop stop)
        {
            if (StopStartId == Guid.Empty)
            {
                StopStart = stop;
            }
            else
            {
                var stops = StopsDir;
                var road = Road.GetRoadByStops(stops.Last(), stop);
                if (road != null)
                {
                    AddRoadOnRoute(road, true);
                }
            }
        }
        public void AddStopOnRouteInvDir(Stop stop)
        {
            if (StopStartInvDirId == Guid.Empty)
            {
                StopStartInvDir = stop;
            }
            else
            {
                var stops = StopsInversionDir;
                var road = Road.GetRoadByStops(stops.Last(), stop);
                if (road != null)
                {
                    AddRoadOnRoute(road, false);
                }
            }
        }

        public override string ToString()
        {
            string res = string.Format("{0}-{1} ({2}-{3}) - {4}", StopStart.Name, StopsDir.Last().Name, StopStartInvDir.Name, StopsInversionDir.Last().Name, Id.ToString("N"));
            return res;
        }

        [XmlIgnore]
        public Stop StopStart
        {
            get { return Stop.Items[StopStartId]; }
            set { StopStartId = value.Id; }
        }

        [XmlIgnore]
        public Stop StopStartInvDir
        {
            get { return Stop.Items[StopStartInvDirId]; }
            set { StopStartInvDirId = value.Id; }
        }

        [XmlIgnore]
        public List<Stop> StopsDir
        {
            get
            {
                var allRoads = RoadsDir;
                var nowStop = StopStart;
                var stops = new List<Stop> {nowStop};
                for (int i = 0; i < allRoads.Count; i++)
                {
                    var nearRoads = nowStop.Roads;
                    Road nextRoad = null;
                    foreach (var nearRoad in nearRoads)
                    {
                        if (allRoads.Contains(nearRoad))
                        {
                            nextRoad = nearRoad;
                        }
                    }
                    if (nextRoad != null)
                    {
                        if (nextRoad.Stop1 == nowStop)
                        {
                            nowStop = nextRoad.Stop2;
                            stops.Add(nowStop);
                        }
                        else if (nextRoad.Stop2 == nowStop)
                        {
                            nowStop = nextRoad.Stop1;
                            stops.Add(nowStop);
                        }
                    }
                }
                return stops;
            }
        }

        [XmlIgnore]
        public List<Stop> StopsInversionDir
        {
            get
            {
                var allRoads = RoadsInversionDir;
                var nowStop = StopStartInvDir;
                var stops = new List<Stop> { nowStop };
                for (int i = 0; i < allRoads.Count; i++)
                {
                    var nearRoads = nowStop.Roads;
                    Road nextRoad = null;
                    foreach (var nearRoad in nearRoads)
                    {
                        if (allRoads.Contains(nearRoad))
                        {
                            nextRoad = nearRoad;
                        }
                    }
                    if (nextRoad != null)
                    {
                        if (nextRoad.Stop1 == nowStop)
                        {
                            nowStop = nextRoad.Stop2;
                            stops.Add(nowStop);
                        }
                        else if (nextRoad.Stop2 == nowStop)
                        {
                            nowStop = nextRoad.Stop1;
                            stops.Add(nowStop);
                        }
                    }
                }
                return stops;
            }
        }

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
        public List<Road> RoadsDir
        {
            get
            {
                var res = new List<Road>();
                foreach (var roadOnRoute in RoadOnRoute.Items.Values)
                {
                    if (roadOnRoute.Route == this && roadOnRoute.Dir)
                    {
                        res.Add(roadOnRoute.Road);
                    }
                }
                return res;
            }
        }

        [XmlIgnore]
        public List<Road> RoadsInversionDir
        {
            get
            {
                var res = new List<Road>();
                foreach (var roadOnRoute in RoadOnRoute.Items.Values)
                {
                    if (roadOnRoute.Route == this && !roadOnRoute.Dir)
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