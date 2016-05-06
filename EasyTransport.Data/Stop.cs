using System.Collections.Generic;

namespace EasyTransport.Data
{
    public class Stop : DataBase<Stop>
    {
        private string _name; // назва зупинки
        private TransportType _transportType; // тип зупинки
        private List<string> _comments; // коментарі до зупинки
        public Stop() : base()
        {

        }

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
    }
}