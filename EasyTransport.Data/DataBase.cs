using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
