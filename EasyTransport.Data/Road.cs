using System;
using System.Collections.Generic;

namespace EasyTransport.Data
{
    public class Road : DataBase<Road>
    {
        private Guid _stop1Id; //ід 1 зупинки
        private Guid _stop2Id; //ід 2 зупинки 

        private int _length; //довжина ділянки
        private List<string> _comments; //коментарі до ділянки
        private string _description; // опис ділянки
        private QualityType _quality; // якість ділянки
        private TransportType _transportType; // тип дороги
        private double _averageSpeed; // середня швидкість
        private double _badWeaterSpeed; // швидкість при поганій погоді
        public Stop Stop1
        {
            get { return Stop.Items[_stop1Id]; }
            set { _stop1Id = value.Id; }
        }

        public Stop Stop2
        {
            get { return Stop.Items[_stop2Id]; }
            set { _stop2Id = value.Id; }
        }

        public Road(Stop stop1, Stop stop2)
        {
            Stop1 = stop1;
            Stop2 = stop2;
        }

        public List<Route> Routes
        {
            get
            {
                var res = new List<Route>();
                foreach (var roadOnRoute in RoadOnRoute.Items.Values)
                {
                    if (roadOnRoute.Road == this)
                    {
                        res.Add(roadOnRoute.Route);
                    }
                }
                return res;
            }
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
    }
}