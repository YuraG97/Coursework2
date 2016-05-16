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
    public partial class FormRouteEditor : Form
    {
        private Route _selectedRoute;

        public FormRouteEditor()
        {
            InitializeComponent();
            _selectedRoute = new Route();
        }

        public FormRouteEditor(Route selectedRoute)
        {
            InitializeComponent();
            _selectedRoute = selectedRoute;
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                TypeTransportCmbbox.Items.Add(trType);
            }
        }

        private void SaveOrCreateRoute_Click(object sender, EventArgs e)
        {

        }
    }
}
