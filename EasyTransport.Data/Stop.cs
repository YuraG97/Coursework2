using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Stop : DataBase<Stop>, IGraphNode<Stop>
    {
        public string Name { get; set; }
        public TransportType StopTransportType { get; set; }
        public PointF Coordinates { get; set; }
        public string Description { get; set; }

        public Stop() { }
        public Stop(TransportType trType, decimal x, decimal y, string name)
        {
            StopTransportType = trType;
            Coordinates = new PointF((float)x, (float)y);
            Name = name;
        }

        public List<IGraphNode<Stop>> GetNearNodes(Func<IGraphNode<Stop>, bool> selector)
        {
            return new List<IGraphNode<Stop>>(NearStops.Where(selector));
        }
        public override string ToString()
        {
            return $"{Name} - {Id.ToString("N")}";
        }
        public static List<Stop> SelectByTransportType(TransportType trType)
        {
            Dictionary<Guid, Stop> items = new Dictionary<Guid, Stop>();
            foreach (var item in Stop.Items)
            {
                if (item.Value.StopTransportType == trType)
                {
                    items.Add(item.Key, item.Value);
                }
            }
            return items.Select(kv => kv.Value).ToList();
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
        public List<Route> RoutesThroughStop
        {
            get
            {
                var result = new List<Route>();
                foreach (var road in Roads.Where(rd => rd.RoadTransportType != TransportType.Walk).ToList())
                {
                    var possibleRoutes = RoadOnRoute.GetRoutesThroughRoad(road);
                    foreach (var possibleRoute in possibleRoutes)
                    {
                        if (!result.Contains(possibleRoute))
                        {
                            result.Add(possibleRoute);
                        }
                    }
                }
                return result;
            }
        }

        [XmlIgnore]
        public List<Tuple<Road, Stop>> NearRoadsAndStops
        {
            get
            {
                var res = new List<Tuple<Road, Stop>>();
                foreach (var road in Road.Items.Values)
                {
                    if (road.RoadTransportType != TransportType.Walk)
                    {
                        if (road.Stop1 == this)
                        {
                            res.Add(new Tuple<Road, Stop>(road, road.Stop2));
                        }
                        else if (road.Stop2 == this && road.IsTwoDir)
                        {
                            res.Add(new Tuple<Road, Stop>(road, road.Stop1));
                        }
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
                    if (road.Stop1 == this)
                    {
                        res.Add(road.Stop2);
                    }
                    else if (road.Stop2 == this && road.IsTwoDir)
                    {
                        res.Add(road.Stop1);
                    }
                }
                return res;
            }
        }

        [XmlIgnore]
        public List<Stop> PossibleStopsToBuildRoute
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