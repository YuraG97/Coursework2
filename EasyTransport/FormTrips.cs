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
    public partial class FormTrips : Form
    {
        private Trip _nowTrip;

        public FormTrips()
        {
            InitializeComponent();
            InitTransportTypes();
            InitRoutesList();
            UpdateListTrips();
        }

        private void InitTransportList()
        {
            TransportCmbbox.Items.Clear();
            foreach (
                var route in Transport.Items.Values.Where(tr => tr.TransportType == _nowTrip.Route.RouteTransportType))
            {
                TransportCmbbox.Items.Add(route);
            }
        }

        private void UpdateListTrips()
        {
            TripsLstbox.Items.Clear();
            if (FilterTransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Route, List<Trip>> items = new Dictionary<Route, List<Trip>>();
                if (FilterTransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Trip.GetRoutesAndTrips();
                }
                else
                {
                    var trType = (TransportType)(FilterTransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Trip.GetRoutesAndTrips())
                    {
                        if (item.Key.RouteTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        if (item.Value.Count >0)
                        {
                            TripsLstbox.Items.Add(item.Key);
                            foreach (var trip in item.Value)
                            {
                                TripsLstbox.Items.Add(trip);
                            }
                        }
                    }
                }
            }
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "All", "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                FilterTransportTypeCmbbox.Items.Add(trType);
            }
            FilterTransportTypeCmbbox.SelectedIndex = 0;
        }

        private void AddNewTripBtn_Click(object sender, EventArgs e)
        {
            _nowTrip = new Trip();
            RoutesCmbbox.Enabled = true;
            ScheduleDataGrid.Rows.Clear();
            //UpdateListTrips();
        }

        private void RemoveTripBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = TripsLstbox.SelectedItem as Trip;
            if (selectedItem != null)
            {
                selectedItem.RemoveItem();
            }
            UpdateListTrips();
        }

        private void TripsLstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = TripsLstbox.SelectedItem as Trip;
            if (selectedItem != null)
            {
                //new FormTripEditor(selectedItem).ShowDialog();
                _nowTrip = selectedItem;
                InitTripParams();
            }
        }

        private void InitTripParams()
        {
            ScheduleDataGrid.Rows.Clear();
            if (_nowTrip.RouteGuid != Guid.Empty)
            {
                RoutesCmbbox.Enabled = false;
                RoutesCmbbox.SelectedItem = _nowTrip.Route;
                InitTransportList();
                ScheduleDataGrid.Rows.Add(_nowTrip.Route.StopsDir.Count + _nowTrip.Route.StopsInversionDir.Count);
                TransportCmbbox.SelectedItem = _nowTrip.Transport;
                UpdateScheduleView();
            }
            if (_nowTrip.TransportGuid != Guid.Empty)
            {
                TransportCmbbox.Enabled = false;
            }
            if (_nowTrip.Schedule.First().First() != DateTime.MinValue)
            {
                TripDateDtPicker.Value = _nowTrip.Schedule.First().First();
            }
            else
            {
                _nowTrip.SetStartDate(TripDateDtPicker.Value);
            }
        }

        private void ScheduleDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var setTime = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var time = DateTime.Parse(setTime.ToString());
            var day = TripDateDtPicker.Value;
            var dateTime = new DateTime(day.Year, day.Month, day.Day, time.Hour, time.Minute, time.Second);
            _nowTrip.SetTimePoint(dateTime, e.RowIndex, e.ColumnIndex - 1);
            UpdateScheduleView();
        }

        private void UpdateScheduleView()
        {
            ScheduleDataGrid.Rows.Clear();
            ScheduleDataGrid.Rows.Add(_nowTrip.Route.Stops.Count);
            for (int i = 0; i < _nowTrip.Route.Stops.Count; i++)
            {
                var stop = _nowTrip.Route.Stops[i];
                ScheduleDataGrid.Rows[i].Cells[0].Value = stop.Name;
            }
            for (int i = 0; i < _nowTrip.Schedule.Count; i++)
            {
                var items = _nowTrip.Schedule[i];
                for (int j = 0; j < items.Count; j++)
                {
                    var time = items[j];
                    ScheduleDataGrid.Rows[i].Cells[j + 1].Value = time.ToShortTimeString();
                }
            }
        }

        private void InitRoutesList()
        {
            RoutesCmbbox.Items.Clear();
            foreach (var route in Route.Items.Values)
            {
                RoutesCmbbox.Items.Add(route);
            }
        }

        private void RoutesCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RoutesCmbbox.SelectedIndex > -1)
            {
                _nowTrip.Route = RoutesCmbbox.SelectedItem as Route;
                ScheduleDataGrid.Rows.Add(_nowTrip.Route.StopsDir.Count + _nowTrip.Route.StopsInversionDir.Count);
                RoutesCmbbox.Enabled = false;
                InitTransportList();
                UpdateScheduleView();
            }
        }

        private void TransportCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TransportCmbbox.SelectedIndex > -1)
            {
                _nowTrip.Transport = TransportCmbbox.SelectedItem as Transport;
                TransportCmbbox.Enabled = false;
                UpdateScheduleView();
            }
        }

        private void TripDateDtPicker_ValueChanged(object sender, EventArgs e)
        {
            _nowTrip.SetStartDate(TripDateDtPicker.Value);
            UpdateScheduleView();
        }

        private void FilterTransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListTrips();
        }
    }
}
