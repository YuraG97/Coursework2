using System.Collections.Generic;

namespace EasyTransport.Data
{
    public class Transport : DataBase<Transport>
    {
        public List<Trip> Trips
        {
            get
            {
                var res = new List<Trip>();
                foreach (var trip in Trip.Items.Values)
                {
                    if (trip.Transport == this)
                    {
                        res.Add(trip);
                    }
                }
                return res;
            }
        }
    }
}