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
    public partial class FormRoutes : Form
    {
        public FormRoutes()
        {
            InitializeComponent();
            InitTransportTypes();
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = {"Bus", "Tramway", "Metro", "Trolleybus"};
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
        }


        private void AddNewRoute_Click(object sender, EventArgs e)
        {
            if (TransportTypeCmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Щоб створити маршрут виберіть його тип транспорту!", "Увага", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button3);
            }
            else if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                new Route();
            }
        }

        private void ChangeRoute_Click(object sender, EventArgs e)
        {

        }

        private void RemoveRoute_Click(object sender, EventArgs e)
        {

        }
    }
}
