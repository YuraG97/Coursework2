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
    public partial class FormRoads : Form
    {
        public FormRoads()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListRoads();
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "All", "Bus", "Tramway", "Metro", "Trolleybus", "Walk" };
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
            TransportTypeCmbbox.SelectedIndex = 0;
        }

        private void UpdateListRoads()
        {
            RoadsLstbox.Items.Clear();
            if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Road> items = new Dictionary<Guid, Road>();
                if (TransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Road.Items;
                }
                else
                {
                    var trType = (TransportType)(TransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Road.Items)
                    {
                        if (item.Value.RoadTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        RoadsLstbox.Items.Add(item.Value);
                    }
                }
            }
        }

        private void AddNewRoadBtn_Click(object sender, EventArgs e)
        {
            new FormRoadEditor().ShowDialog();
            UpdateListRoads();
        }

        private void ChangeRoadBtn_Click(object sender, EventArgs e)
        {
            var selectedRoad = RoadsLstbox.SelectedItem as Road;
            if (selectedRoad != null)
            {
                new FormRoadEditor(selectedRoad).ShowDialog();
            }
            UpdateListRoads();
        }

        private void CreateCopyRoadBtn_Click(object sender, EventArgs e)
        {
            var selectedRoad = RoadsLstbox.SelectedItem as Road;
            if (selectedRoad != null)
            {
                new Road(selectedRoad.Stop1, selectedRoad.Stop2, selectedRoad.IsTwoDir, selectedRoad.Length,
                    selectedRoad.RoadTransportType, selectedRoad.Quality);
            }
            UpdateListRoads();
        }

        private void RemoveRoadBtn_Click(object sender, EventArgs e)
        {
            var selectedRoad = RoadsLstbox.SelectedItem as Road;
            if (selectedRoad != null)
            {
                Road.RemoveItem(selectedRoad.Id);
            }
            UpdateListRoads();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListRoads();
        }
    }
}
