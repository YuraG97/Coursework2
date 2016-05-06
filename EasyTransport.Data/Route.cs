using System.Collections.Generic;

namespace EasyTransport.Data
{
    public class Route : DataBase<Route>
    {

        public Route()
        {
            
        }

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
    }
}