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
        private readonly Route _selectedRoute;

        public FormRouteEditor()
        {
            InitializeComponent();
            InitTransportTypes();
            _selectedRoute = new Route();
            UpdateRouteView();
        }

        public FormRouteEditor(Route selectedRoute)
        {
            InitializeComponent();
            InitTransportTypes();
            _selectedRoute = selectedRoute;
            InitSavedParametrs();
            TransportTypeCmbbox.Enabled = false;
            UpdateRouteView();
        }

        private void InitSavedParametrs()
        {
            SaveOrCreateRoute.Text = "Зберегти";
            TransportTypeCmbbox.SelectedIndex = (int) _selectedRoute.RouteTransportType;
            RouteNameTxtbox.Text = _selectedRoute.Name;
            TicketCostNumupdown.Value = (decimal) _selectedRoute.TicketCost;
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
        }

        private void UpdateRouteView()
        {
            NextStopCmbbox.Items.Clear();
            NextStopCmbbox.ResetText();
            NextStopInvDirectCmbbox.Items.Clear();
            NextStopInvDirectCmbbox.ResetText();
            DirectStopsLstbox.Items.Clear();
            InverseDirectStopsLstbox.Items.Clear();

            if (_selectedRoute.StopStartId == Guid.Empty)
            {
                var stops = Stop.SelectByTransportType((TransportType) TransportTypeCmbbox.SelectedIndex);
                foreach (var stop in stops)
                {
                    NextStopCmbbox.Items.Add(stop);
                }
            }
            else
            {
                var stopsList = _selectedRoute.StopsDir;
                foreach (var stop in stopsList)
                {
                    DirectStopsLstbox.Items.Add(stop);
                }
                var nextStops = stopsList.Last().NearStops;
                foreach (var stop in nextStops)
                {
                    NextStopCmbbox.Items.Add(stop);
                }
            }

            if (_selectedRoute.StopStartInvDirId == Guid.Empty)
            {
                var stops = Stop.SelectByTransportType((TransportType) TransportTypeCmbbox.SelectedIndex);
                foreach (var stop in stops)
                {
                    NextStopInvDirectCmbbox.Items.Add(stop);
                }
            }
            else
            {
                var inversStopsList = _selectedRoute.StopsInversionDir;
                foreach (var stop in inversStopsList)
                {
                    InverseDirectStopsLstbox.Items.Add(stop);
                }
                var nextStopsInv = inversStopsList.Last().NearStops;
                foreach (var stop in nextStopsInv)
                {
                    NextStopInvDirectCmbbox.Items.Add(stop);
                }
            }

            DirectStopsLstbox.SelectedIndex = DirectStopsLstbox.Items.Count - 1;
            InverseDirectStopsLstbox.SelectedIndex = InverseDirectStopsLstbox.Items.Count - 1;
        }


        private void SaveOrCreateRoute_Click(object sender, EventArgs e)
        {
            _selectedRoute.RouteTransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            _selectedRoute.Name = RouteNameTxtbox.Text;
            _selectedRoute.TicketCost = (double) TicketCostNumupdown.Value;
        }

        private void AddStopToRouteBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = NextStopCmbbox.SelectedItem as Stop;
            if (selectedItem != null)
            {
                _selectedRoute.AddStopOnRoute(selectedItem);
            }
            UpdateRouteView();
        }

        private void RemoveStopRouteBtn_Click(object sender, EventArgs e)
        {
            UpdateRouteView();
        }

        private void AddStopToRouteInvDirBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = NextStopInvDirectCmbbox.SelectedItem as Stop;
            if (selectedItem != null)
            {
                _selectedRoute.AddStopOnRouteInvDir(selectedItem);
            }
            UpdateRouteView();
        }

        private void RemoveStopRouteInvDirBtn_Click(object sender, EventArgs e)
        {
            UpdateRouteView();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedRoute.RouteTransportType = (TransportType)TransportTypeCmbbox.SelectedIndex;
            TransportTypeCmbbox.Enabled = false;
            UpdateRouteView();
        }
    }
}
