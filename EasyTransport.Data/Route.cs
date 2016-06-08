using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EasyTransport.Data.Enums;

namespace EasyTransport.Data
{
    [Serializable]
    public class Route : DataBase<Route>, IGraphNode<Route>
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
        public List<List<Stop>> GetPathFromStopToStop(Stop stop1, Stop stop2)
        {
            var startRoad = stop1.Roads.Where(rd => RoadOnRoute.IsRoadOnRoute(rd, this));
            var tempResult = new List<List<IGraphNode<Stop>>>();
            Func<IGraphNode<Stop>, bool> thisRouteSelector = (node) => (node as Stop).RoutesThroughStop.Contains(this);
            PathFinder.RecoursionFindPath(stop1, stop2, new List<IGraphNode<Stop>>(), tempResult, thisRouteSelector);
            var result = tempResult.Select(temp => temp.Select(node => node as Stop).ToList()).ToList();
            return result;
        }
        public static List<Tuple<Stop, Stop>> GetTransit(Route route1, Route route2)
        {
            var result = new List<Tuple<Stop, Stop>>();
            var stops = route1.Stops;
            foreach (var stop in stops)
            {
                if (stop.RoutesThroughStop.Contains(route2))
                {
                    result.Add(new Tuple<Stop, Stop>(stop, stop));
                }
                else
                {
                    var nearTransitRoads = stop.Roads.Where((rd) => rd.RoadTransportType == TransportType.Walk).ToList();
                    foreach (var road in nearTransitRoads)
                    {
                        if (road.Stop1 == stop && route2.Stops.Contains(road.Stop2))
                        {
                            result.Add(new Tuple<Stop, Stop>(road.Stop1, road.Stop2));
                        }
                        else if (road.Stop2 == stop && route2.Stops.Contains(road.Stop1))
                        {
                            result.Add(new Tuple<Stop, Stop>(road.Stop2, road.Stop1));
                        }
                    }
                }
            }
            return result;
        }
        public List<IGraphNode<Route>> GetNearNodes(Func<IGraphNode<Route>, bool> selector)
        {
            return new List<IGraphNode<Route>>(NearRoutes);
        }
        public override bool Equals(object obj)
        {
            var comp = obj as Route;
            return comp != null && Id == comp.Id;
        }

        public override string ToString()
        {
            string startStName;
            string endStName;
            string startInvStName;
            string endInvStName;
            if (StopStartId == Guid.Empty)
            {
                startStName = "Null";
                endStName = "Null";
            }
            else
            {
                startStName = StopStart.Name;
                endStName = StopsDir.Last().Name;
            }
            if (StopStartInvDirId == Guid.Empty)
            {
                startInvStName = "Null";
                endInvStName = "Null";
            }
            else
            {
                startInvStName = StopStartInvDir.Name;
                endInvStName = StopsInversionDir.Last().Name;
            }
            string res = string.Format("{0}-{1} ({2}-{3}) - {4}", startStName, endStName, startInvStName, endInvStName, Id.ToString("N"));
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
        public List<Route> NearRoutes
        {
            get
            {
                var result = new List<Route>();
                foreach (var stop in Stops)
                {
                    var nearRoads = stop.Roads;
                    var nearTransit = nearRoads.Where(transit => transit.RoadTransportType == TransportType.Walk).ToList();
                    var possibleRoutes = new List<Route>();
                    foreach (var road in nearTransit)
                    {
                        if (!Stops.Contains(road.Stop1))
                        {
                            possibleRoutes = road.Stop1.RoutesThroughStop;
                        }
                        else if (!Stops.Contains(road.Stop2))
                        {
                            possibleRoutes = road.Stop2.RoutesThroughStop;
                        }
                    }
                    possibleRoutes.AddRange(stop.RoutesThroughStop);
                    foreach (var route in possibleRoutes)
                    {
                        if (!result.Contains(route) && route != this)
                        {
                            result.Add(route);
                        }
                    }
                }

                return result;
            }
        }

        [XmlIgnore]
        public List<Stop> StopsDir
        {
            get
            {
                var allRoads = RoadsDir;
                var nowStop = StopStart;
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
        public List<Stop> Stops
        {
            get
            {
                var result = new List<Stop>();
                result.AddRange(StopsDir);
                result.AddRange(StopsInversionDir);
                return result;
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