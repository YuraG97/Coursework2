using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    [Serializable]
    public class Stop : DataBase<Stop>
    {
        public string Name { get; set; }
        public TransportType TransportType1 { get; set; }
        public List<string> Comments { get; set; }

        public Stop() { }

        public List<Road> Roads
        {
            get
            {
                var res = new List<Road>();
                foreach (var road in Road.Items.Values)
                {
                    if (road.Stop1 == this || road.Stop2 == this)
                    {
                        res.Add(road);
                    }
                }
                return res;
            }
        }
        public static void Serialize()
        {
            string fileName = "Stop.xml";
            Stop[] stopsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(Stop[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, stopsArr);
            }
        }
    }
}