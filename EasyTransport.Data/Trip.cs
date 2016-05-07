using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Trip : DataBase<Trip>
    {
        private Guid _transport;
        private Guid _route;

        public Trip() { }
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

        public static void Serialize()
        {
            string fileName = "Trip.xml";
            Trip[] stopsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(Trip[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, stopsArr);
            }
        }
    }
}