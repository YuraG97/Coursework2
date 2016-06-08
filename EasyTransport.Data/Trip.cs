using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    //TODO : add counting points time based on route

    [Serializable]
    public class Trip : DataBase<Trip>
    {
        public Guid TransportGuid { get; set; }
        public Guid RouteGuid { get; set; }
        public List<List<DateTime>> Schedule { get; set; }

        public Trip()
        { }

        public void SetStartDate(DateTime dateTime)
        {
            foreach (var item in Schedule)
            {
                var year = dateTime.Year;
                var month = dateTime.Month;
                var day = dateTime.Day;
                for (int i = 0; i < item.Count; i++)
                {
                    item[i] = new DateTime(year, month, day, item[i].Hour, item[i].Minute, item[i].Second);
                }
            }
        }
        public void SetTimePoint(DateTime dateTime, int row, int column)
        {
            var items = Schedule[row];
            var start = items[column];
            var diff = new TimeSpan(0, dateTime.Hour - start.Hour, dateTime.Minute - start.Minute,
                dateTime.Second - start.Second);
            items[column] = items[column].Add(diff);
            for (int j = column + 1; j < 3; j++)
            {
                if (j == 1) continue;
                items[j] = items[j].Add(diff);
            }
            for (int i = row + 1; i < Schedule.Count; i++)
            {
                items = Schedule[i];
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1) continue;
                    items[j] = items[j].Add(diff);
                }
            }
        }

        public static Dictionary<Route, List<Trip>> GetRoutesAndTrips()
        {
            var result = new Dictionary<Route, List<Trip>>();
            foreach (var route in Data.Route.Items.Values)
            {
                result[route] = new List<Trip>();
                foreach (var trip in Items.Values)
                {
                    if (trip.Route == route)
                    {
                        result[route].Add(trip);
                    }
                }
            }
            return result;
        }

        public override string ToString()
        {
            string res = string.Format("{3}-{0}-{1}-{2}", Schedule[0][0].ToLongTimeString(),
                Schedule.Last()[2].ToLongTimeString(), Id.ToString("N"),Schedule.First()[0].ToLongDateString());
            return "\t" + res;
        }

        [XmlIgnore]
        public Transport Transport
        {
            get { return Transport.Items[TransportGuid]; }
            set { TransportGuid = value.Id; }
        }

        [XmlIgnore]
        public Route Route
        {
            get { return Route.Items[RouteGuid]; }
            set
            {
                RouteGuid = value.Id;
                var stops = value.Stops;
                Schedule = new List<List<DateTime>>(stops.Count);
                for (int i = 0; i < stops.Count; i++)
                {
                    Schedule.Add(new List<DateTime>(3) {new DateTime(), new DateTime(), new DateTime()});
                }
            }
        }

        #region Serialize And Deserialize
        public static void Deserialize()
        {
            string fileName = "Trip.xml";
            Deserialize(fileName);
        }

        public static void Serialize()
        {
            string fileName = "Trip.xml";
            Serialize(fileName);
        }
#endregion
    }
}