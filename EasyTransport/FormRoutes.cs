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
using EasyTransport.Data.Enums;

namespace EasyTransport
{
    public partial class FormRoutes : Form
    {
        public FormRoutes()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListRoutes();
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = {"All", "Bus", "Tramway", "Metro", "Trolleybus"};
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
            TransportTypeCmbbox.SelectedIndex = 0;
        }

        private void UpdateListRoutes()
        {
            RoutesLstbox.Items.Clear();
            if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Route> items = new Dictionary<Guid, Route>();
                if (TransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Route.Items;
                }
                else
                {
                    var trType = (TransportType)(TransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Route.Items)
                    {
                        if (item.Value.RouteTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        RoutesLstbox.Items.Add(item.Value);
                    }
                }
            }
        }

        private void AddNewRoute_Click(object sender, EventArgs e)
        {
            if (TransportTypeCmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Щоб створити маршрут виберіть його тип транспорту!", "Увага", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);
            }
            else if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                new FormRouteEditor().ShowDialog();
            }
            UpdateListRoutes();
        }

        private void ChangeRoute_Click(object sender, EventArgs e)
        {
            var selectedRoute = RoutesLstbox.SelectedItem as Route;
            if (selectedRoute != null)
            {
                new FormRouteEditor(selectedRoute).ShowDialog();
            }
            UpdateListRoutes();
        }

        private void RemoveRoute_Click(object sender, EventArgs e)
        {
            var selectedRoute = RoutesLstbox.SelectedItem as Route;
            if (selectedRoute != null)
            {
                Route.RemoveItem(selectedRoute.Id);
            }
            UpdateListRoutes();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListRoutes();
        }
    }
}
