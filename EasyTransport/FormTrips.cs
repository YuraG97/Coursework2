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
        public FormTrips()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListTrips();
        }

        private void UpdateListTrips()
        {
            TripsLstbox.Items.Clear();
            if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Route, List<Trip>> items = new Dictionary<Route, List<Trip>>();
                if (TransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Trip.GetRoutesAndTrips();
                }
                else
                {
                    var trType = (TransportType)(TransportTypeCmbbox.SelectedIndex - 1);
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
                TransportTypeCmbbox.Items.Add(trType);
            }
            TransportTypeCmbbox.SelectedIndex = 0;
        }

        private void AddNewTripBtn_Click(object sender, EventArgs e)
        {
            new FormTripEditor().ShowDialog();
            UpdateListTrips();
        }

        private void ChangeTripBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = TripsLstbox.SelectedItem as Trip;
            if (selectedItem != null)
            {
                new FormTripEditor(selectedItem).ShowDialog();
            }
            UpdateListTrips();
        }

        private void CreateCopyTripBtn_Click(object sender, EventArgs e)
        {
            UpdateListTrips();
        }

        private void RemoveTripBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = TripsLstbox.SelectedItem as Trip;
            if (selectedItem != null)
            {
                Trip.RemoveItem(selectedItem.Id);
            }
            UpdateListTrips();
        }
    }
}
