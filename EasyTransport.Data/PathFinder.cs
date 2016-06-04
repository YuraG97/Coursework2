using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyTransport.Data
{
    public class PathFinder
    {
        private readonly Stop _stop1;
        private readonly Stop _stop2;
        private readonly List<Stop> _additionPoints;

        public PathFinder()
        {

        }
        public PathFinder(Stop stop1, Stop stop2, List<Stop> additionPoints)
        {
            _stop1 = stop1;
            _stop2 = stop2;
            _additionPoints = additionPoints;
        }

        public void Find()
        {
            var routesThroughStop1 = _stop1.RoutesThroughStop;
            var routesThroughStop2 = _stop2.RoutesThroughStop;
            var addRoutes = new List<List<Route>> { new List<Route>() };
            foreach (var additionPoint in _additionPoints)
            {
                var tempRoutes = new List<List<Route>>();
                foreach (var addRoute in addRoutes)
                {
                    var pointRoutes = additionPoint.RoutesThroughStop;
                    foreach (var route in pointRoutes)
                    {
                        var tempRoute = new List<Route>(addRoute) { route };
                        tempRoutes.Add(tempRoute);
                    }
                }
                addRoutes = tempRoutes;
            }
            var result = new List<List<List<Stop>>>();
            foreach (var route1 in routesThroughStop1)
            {
                foreach (var route2 in routesThroughStop2)
                {
                    foreach (var addRoute in addRoutes)
                    {
                        result.AddRange(FindRoutes(_stop1, route1, _stop2, route2, _additionPoints, addRoute));
                    }
                }
            }
        }

        private List<List<List<Stop>>> FindRoutes(Stop stop1, Route route1, Stop stop2, Route route2, List<Stop> tempStops,
            List<Route> tempRoutes)
        {
            var res = new List<List<List<Stop>>>();

            if (route1 == route2 && tempStops.Count == 0)
            {
                res.Add(route1.GetPathFromStopToStop(stop1, stop2));
            }
            else if (tempStops.Count > 0)
            {
                var results = new List<List<List<Stop>>>();
                var fullRoute = new List<Route>(tempRoutes) { route2 };
                fullRoute.Insert(0, route1);
                var fullStops = new List<Stop>(tempStops) { stop2 };
                fullStops.Insert(0, stop1);
                Route r1;
                Route r2;
                Stop s1;
                Stop s2;
                for (int i = 0; i < fullRoute.Count-1; i++)
                {
                    r1 = fullRoute[i];
                    r2 = fullRoute[i + 1];
                    s1 = fullStops[i];
                    s2 = fullStops[i + 1];
                    if (r1 == r2)
                    {
                        res.Add(route1.GetPathFromStopToStop(s1, s2));
                    }
                    else
                    {
                        var resultRoutes = new List<List<IGraphNode<Route>>>();
                        var temp = new List<IGraphNode<Route>>();
                        RecoursionFindPath(r1, r2, temp, resultRoutes, null);
                        if (resultRoutes.Count > 0)
                        {
                            foreach (var resultRoute in resultRoutes)
                            {
                                var tempRes = new List<List<Stop>>();
                                Stop startStop = s1;
                                Stop endStop = null;
                                for (int j = 0; j < resultRoutes.Count - 1; j++)
                                {
                                    var transit = Route.GetTransit(resultRoute[j] as Route, resultRoute[j + 1] as Route).First();
                                    endStop = transit.Item1;
                                    tempRes.Add((resultRoute[j] as Route).GetPathFromStopToStop(startStop, endStop).First());
                                    startStop = transit.Item2;
                                }
                                endStop = s2;
                                tempRes.Add((resultRoute.Last() as Route).GetPathFromStopToStop(startStop, endStop).First());
                                res.Add(tempRes);
                            }
                        }
                    }
                }
            }

            return res;
        }

        public static void RecoursionFindPath<T>(IGraphNode<T> point1, IGraphNode<T> point2, List<IGraphNode<T>> visited,
            List<List<IGraphNode<T>>> result, Func<IGraphNode<T>, bool> selector) where T : IGraphNode<T>
        {
            visited.Add(point1);
            if (point1 == point2)
            {
                visited.Add(point1);
                result.Add(new List<IGraphNode<T>>(visited));
                visited.Remove(point1);
                return;
            }
            var nextRoutes = point1.GetNearNodes(selector);
            foreach (var nextRoute in nextRoutes)
            {
                if (!visited.Contains(nextRoute))
                {
                    visited.Add(nextRoute);
                    RecoursionFindPath(nextRoute, point2, visited, result, selector);
                    visited.Remove(nextRoute);
                }
            }
        }
    }
}