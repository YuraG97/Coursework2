using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EasyTransport.Data
{
    public class DataBase<T> where T:DataBase<T>
    {
        public static readonly Dictionary<Guid,T> Items = new Dictionary<Guid, T>();
        public Guid Id { get; set; }

        public DataBase()
        {
            Id = Guid.NewGuid();
            Items.Add(Id, (T)this);
        }

        public override string ToString()
        {
            return "Object #" + Id;
        }

        protected static void Deserialize(string fileName)
        {
            var formatter = new XmlSerializer(typeof(T[]));
            var res = new Dictionary<Guid, T>();
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                T[] itemsArr = formatter.Deserialize(fs) as T[];
                if (itemsArr != null)
                    foreach (T item in itemsArr)
                    {
                        res.Add(item.Id, item);
                    }
            }
            Items.Clear();
            foreach (var kv in res)
            {
                Items.Add(kv.Key, kv.Value);
            }
        }

        protected static void Serialize(string fileName)
        {
            T[] itemsArr = Items.Values.ToArray();
            var formatter = new XmlSerializer(typeof(T[]));
            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, itemsArr);
            }
        }
    }
}
