using System;
using System.Collections.Generic;

namespace EasyTransport.Data
{
    public class RoadOnRoute : DataBase<RoadOnRoute>
    {
        private Guid _road;
        private Guid _route;

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
    }
}