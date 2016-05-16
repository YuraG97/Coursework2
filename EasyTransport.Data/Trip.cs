using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Trip : DataBase<Trip>
    {
        public Guid TransportGuid { get; set; }
        public Guid RouteGuid { get; set; }

        public Trip() { }

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
            set { RouteGuid = value.Id; }
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