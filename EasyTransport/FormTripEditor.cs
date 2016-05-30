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
    public partial class FormTripEditor : Form
    {
        private readonly Trip _nowTrip;

        public FormTripEditor()
        {
            InitializeComponent();
            InitRoutesList();
            _nowTrip = new Trip();
            //_nowTrip.SetStartDate(TripDateDtPicker.Value);
        }
        public FormTripEditor(Trip nowTrip)
        {
            InitializeComponent();
            _nowTrip = nowTrip;
            RoutesCmbbox.SelectedItem = _nowTrip.Route;
            TripDateDtPicker.Value = _nowTrip.Schedule.First().First();
            ScheduleDataGrid.Rows.Add(_nowTrip.Route.StopsDir.Count + _nowTrip.Route.StopsInversionDir.Count - 1);
            UpdateScheduleView();
        }

        private void UpdateScheduleView()
        {
            //ScheduleDataGrid.Rows.Clear();
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

        public void InitRoutesList()
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
                ScheduleDataGrid.Rows.Add(_nowTrip.Route.StopsDir.Count + _nowTrip.Route.StopsInversionDir.Count - 1);
            }
            RoutesCmbbox.Enabled = false;
            UpdateScheduleView();
        }

        private void ScheduleDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;
            var setTime = senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var time = DateTime.Parse(setTime.ToString());
            var day = TripDateDtPicker.Value;
            var dateTime = new DateTime(day.Year, day.Month, day.Day, time.Hour, time.Minute, time.Second);
            _nowTrip.SetTimePoint(dateTime, e.RowIndex, e.ColumnIndex - 1);
            UpdateScheduleView();
        }

        private void TripDateDtPicker_ValueChanged(object sender, EventArgs e)
        {
            _nowTrip.SetStartDate(TripDateDtPicker.Value);
        }
    }
}
