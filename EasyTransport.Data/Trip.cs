using System;

namespace EasyTransport.Data
{
    public class Trip : DataBase<Trip>
    {
        private Guid _transport;
        private Guid _route;

        public Transport Transport
        {
            get { return Transport.Items[_transport]; }
            set { _transport = value.Id; }
        }

        public Route Route
        {
            get { return Route.Items[_route]; }
            set { _route = value.Id; }
        }
    }
}