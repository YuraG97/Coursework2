using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Transport : DataBase<Transport>
    {
        public Transport()
        {
            
        }
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

        public static void Serialize()
        {
            string fileName = "Transport.xml";
            Transport[] stopsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(Transport[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, stopsArr);
            }
        }
    }
}