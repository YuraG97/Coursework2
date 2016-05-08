using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTransport.Data;

namespace EasyTransport
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void RoutesBtn_Click(object sender, EventArgs e)
        {
            new FormRoutes().Show();
        }

        private void TripsBtn_Click(object sender, EventArgs e)
        {

        }

        private void TransportBtn_Click(object sender, EventArgs e)
        {

        }

        private void AboutProgramMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().Show();
        }

        #region TestSerialize
        //private void TestSerialize()
        //{
        //    var stop1 = new Stop() { Name = "Lolke", StopTransportType = TransportType.Bus };
        //    var stop2 = new Stop() { Name = "lalka", StopTransportType = TransportType.Bus };
        //    var stop3 = new Stop() { Name = "dniwe", StopTransportType = TransportType.Bus };
        //    var road1 = new Road(stop1, stop2)
        //    {
        //        AverageSpeed = 4,
        //        BadWeaterSpeed = 5,
        //        Description = "bbbb",
        //        Length = 15,
        //        Quality = QualityType.Good
        //    };
        //    var road2 = new Road(stop2, stop3)
        //    {
        //        AverageSpeed = 10,
        //        BadWeaterSpeed = 10,
        //        Description = "aaaa",
        //        Length = 40,
        //        Quality = QualityType.Middle
        //    };
        //    var road3 = new Road(stop1, stop3)
        //    {
        //        AverageSpeed = 2,
        //        BadWeaterSpeed = 2,
        //        Description = "vvvvv",
        //        Length = 50,
        //        Quality = QualityType.Bad
        //    };
        //    var route1 = new Route();
        //    var route2 = new Route();
        //    var roadOnRoute1 = new RoadOnRoute(road1, route1);
        //    var roadOnRoute2 = new RoadOnRoute(road2, route1);
        //    var roadOnRoute3 = new RoadOnRoute(road3, route2);
        //    var transport1 = new Transport();
        //    var transport2 = new Transport();
        //    var trip1 = new Trip() { Transport = transport1, Route = route1 };
        //    var trip2 = new Trip() { Transport = transport2, Route = route2 };
        //}
#endregion

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Road.Serialize();
            RoadOnRoute.Serialize();
            Route.Serialize();
            Stop.Serialize();
            Transport.Serialize();
            Trip.Serialize();
            MessageBox.Show("Data succesful saved!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Road.Deserialize();
            RoadOnRoute.Deserialize();
            Route.Deserialize();
            Stop.Deserialize();
            Transport.Deserialize();
            Trip.Deserialize();
            MessageBox.Show("Data succesful loaded!");
        }
    }
}
