using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using EasyTransport.Data.Enums;

namespace EasyTransport.Data
{
    [Serializable]
    public class Transport : DataBase<Transport>
    {
        public string SerieName { get; set; }
        public string SerialNumber { get; set; }
        public string Mark { get; set; }
        public TransportType TransportType { get; set; }
        public double AllDistance { get; set; }

        public Transport()
        {
            
        }
        public Transport(string serieName, string serialNumber, string mark, TransportType transportType)
        {
            SerieName = serieName;
            SerialNumber = serialNumber;
            Mark = mark;
            TransportType = transportType;
        }

        public override string ToString()
        {
            string res = string.Format("{0}-{1}-{2}-{3}-{4}", TransportType, Mark, SerieName, SerialNumber,
                Id.ToString("N"));
            return res;
        }

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