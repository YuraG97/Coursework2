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
        public Transport() { }

        [XmlIgnore]
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

        #region Serialize And Deserialize
        public static void Deserialize()
        {
            string fileName = "Transport.xml";
            Deserialize(fileName);
        }

        public static void Serialize()
        {
            string fileName = "Transport.xml";
            Serialize(fileName);
        }
#endregion
    }
}