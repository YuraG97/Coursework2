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
        private List<Route> _nowRoutes;
        private Route _nowRoute;

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
                FilterTransportTypeCmbbox.Items.Add(trType);
                if (trType != "All")
                {
                    TransportTypeCmbbox.Items.Add(trType);
                }
            }
            FilterTransportTypeCmbbox.SelectedIndex = 0;
        }

        private void UpdateListRoutes()
        {
            RoutesList.Rows.Clear();
            if (FilterTransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Route> items = new Dictionary<Guid, Route>();
                if (FilterTransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Route.Items;
                }
                else
                {
                    var trType = (TransportType)(FilterTransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Route.Items)
                    {
                        if (item.Value.RouteTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items?.Count > 0)
                {
                    RoutesList.Rows.Add(items.Count);
                    _nowRoutes = items.Values.ToList();
                    var i = 0;
                    foreach (var item in items)
                    {
                        RoutesList.Rows[i].Cells[0].Value = item.Key.ToByteArray()[0];
                        RoutesList.Rows[i].Cells[1].Value = item.Value.Name;
                        RoutesList.Rows[i].Cells[2].Value = item.Value.GetDir();
                        RoutesList.Rows[i].Cells[3].Value = item.Value.GetInvDir();
                        i++;
                    }
                }
            }
        }

        private void AddNewRoute_Click(object sender, EventArgs e)
        {
            _nowRoute = new Route();
            //UpdateListRoutes();
        }

        private void RemoveRoute_Click(object sender, EventArgs e)
        {
            var selectedRoute = _nowRoutes[RoutesList.SelectedRows[0].Index];
            if (selectedRoute != null)
            {
                selectedRoute.RemoveItem();
            }
            UpdateListRoutes();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListRoutes();
        }

        private void SaveOrCreateRoute_Click(object sender, EventArgs e)
        {
            _nowRoute.RouteTransportType = (TransportType)TransportTypeCmbbox.SelectedIndex;
            _nowRoute.Name = RouteNameTxtbox.Text;
            _nowRoute.TicketCost = (double)TicketCostNumupdown.Value;
        }

        private void AddStopToRouteBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = NextStopCmbbox.SelectedItem as Stop;
            if (selectedItem != null)
            {
                _nowRoute.AddStopOnRoute(selectedItem);
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
                _nowRoute.AddStopOnRouteInvDir(selectedItem);
            }
            UpdateRouteView();
        }

        private void RemoveStopRouteInvDirBtn_Click(object sender, EventArgs e)
        {
            UpdateRouteView();
        }

        private void UpdateRouteView()
        {
            NextStopCmbbox.Items.Clear();
            NextStopCmbbox.ResetText();
            NextStopInvDirectCmbbox.Items.Clear();
            NextStopInvDirectCmbbox.ResetText();
            DirectStopsLstbox.Items.Clear();
            InverseDirectStopsLstbox.Items.Clear();

            if (_nowRoute.StopStartId == Guid.Empty)
            {
                var stops = Stop.SelectByTransportType((TransportType)TransportTypeCmbbox.SelectedIndex);
                foreach (var stop in stops)
                {
                    NextStopCmbbox.Items.Add(stop);
                }
            }
            else
            {
                var stopsList = _nowRoute.StopsDir;
                foreach (var stop in stopsList)
                {
                    DirectStopsLstbox.Items.Add(stop);
                }
                var nextStops = stopsList.Last().PossibleStopsToBuildRoute;
                foreach (var stop in nextStops)
                {
                    NextStopCmbbox.Items.Add(stop);
                }
            }

            if (_nowRoute.StopStartInvDirId == Guid.Empty)
            {
                var stops = Stop.SelectByTransportType((TransportType)TransportTypeCmbbox.SelectedIndex);
                foreach (var stop in stops)
                {
                    NextStopInvDirectCmbbox.Items.Add(stop);
                }
            }
            else
            {
                var inversStopsList = _nowRoute.StopsInversionDir;
                foreach (var stop in inversStopsList)
                {
                    InverseDirectStopsLstbox.Items.Add(stop);
                }
                var nextStopsInv = inversStopsList.Last().PossibleStopsToBuildRoute;
                foreach (var stop in nextStopsInv)
                {
                    NextStopInvDirectCmbbox.Items.Add(stop);
                }
            }

            DirectStopsLstbox.SelectedIndex = DirectStopsLstbox.Items.Count - 1;
            InverseDirectStopsLstbox.SelectedIndex = InverseDirectStopsLstbox.Items.Count - 1;
        }

        private void InitSavedParametrs()
        {
            TransportTypeCmbbox.SelectedIndex = (int)_nowRoute.RouteTransportType;
            RouteNameTxtbox.Text = _nowRoute.Name;
            TicketCostNumupdown.Value = (decimal)_nowRoute.TicketCost;
            UpdateRouteView();
        }

        private void RoutesList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (RoutesList.SelectedRows.Count > 0)
            {
                _nowRoute = _nowRoutes[RoutesList.SelectedRows[0].Index];
                InitSavedParametrs();
            }
        }

        private void TransportTypeCmbbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _nowRoute.RouteTransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            UpdateRouteView();
        }
    }
}
