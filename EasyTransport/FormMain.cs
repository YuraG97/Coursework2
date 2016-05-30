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
            new FormTrips().Show();
        }

        private void TransportBtn_Click(object sender, EventArgs e)
        {
            new FormTransports().Show();
        }

        private void AboutProgramMenuItem_Click(object sender, EventArgs e)
        {
            new FormAbout().Show();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Clear all items
            //Road.Items.Clear();
            //RoadOnRoute.Items.Clear();
            //Route.Items.Clear();
            //Stop.Items.Clear();
            //Transport.Items.Clear();
            //Trip.Items.Clear();
#endregion

            Road.Serialize();
            Route.Serialize();
            RoadOnRoute.Serialize();
            Stop.Serialize();
            Transport.Serialize();
            Trip.Serialize();
            //MessageBox.Show("Data succesful saved!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Road.Deserialize();
            RoadOnRoute.Deserialize();
            Route.Deserialize();
            Stop.Deserialize();
            Transport.Deserialize();
            Trip.Deserialize();
            //MessageBox.Show("Data succesful loaded!");
        }

        private void RoadsBtn_Click(object sender, EventArgs e)
        {
            new FormRoads().Show();
        }

        private void StopsBtn_Click(object sender, EventArgs e)
        {
            new FormStops().Show();
        }
    }
}
