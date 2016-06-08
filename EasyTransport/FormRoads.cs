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
        private List<Road> _nowRoads;
        private Road _nowRoad;

        public FormRoads()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListRoads();
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "All", "Bus", "Tramway", "Metro", "Trolleybus", "Walk" };
            string[] qualityTypes = { "Good", "Middle", "Bad" };
            foreach (var trType in transpTypes)
            {
                FilterTransportTypeCmbbox.Items.Add(trType);
                if (trType != "All")
                {
                    TransportTypeCmbbox.Items.Add(trType);
                }
            }
            foreach (var qualityType in qualityTypes)
            {
                QualityCmbbox.Items.Add(qualityType);
            }
            FilterTransportTypeCmbbox.SelectedIndex = 0;
        }

        private void UpdateListRoads()
        {
            RoadsList.Rows.Clear();
            if (FilterTransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Road> items = new Dictionary<Guid, Road>();
                if (FilterTransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Road.Items;
                }
                else
                {
                    var trType = (TransportType)(FilterTransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Road.Items)
                    {
                        if (item.Value.RoadTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items?.Count > 0)
                {
                    RoadsList.Rows.Add(items.Count);
                    _nowRoads = items.Values.ToList();
                    var i = 0;
                    foreach (var item in items)
                    {
                        RoadsList.Rows[i].Cells[0].Value = item.Key.ToByteArray()[0];
                        if (item.Value.Stop1 != null)
                            RoadsList.Rows[i].Cells[1].Value = item.Value.Stop1.ToString();
                        if (item.Value.Stop2 != null)
                            RoadsList.Rows[i].Cells[2].Value = item.Value.Stop2.ToString();
                        RoadsList.Rows[i].Cells[3].Value = item.Value.RoadTransportType.ToString();
                        i++;
                    }
                }
            }
        }

        private void AddNewRoadBtn_Click(object sender, EventArgs e)
        {
            _nowRoad = new Road();
            //UpdateListRoads();
        }

        private void CreateCopyRoadBtn_Click(object sender, EventArgs e)
        {
            var selectedRoad = _nowRoads[RoadsList.SelectedRows[0].Index];
            if (selectedRoad != null)
            {
                new Road(selectedRoad.Stop1, selectedRoad.Stop2, selectedRoad.IsTwoDir, selectedRoad.Length,
                    selectedRoad.RoadTransportType, selectedRoad.Quality);
            }
            UpdateListRoads();
        }

        private void RemoveRoadBtn_Click(object sender, EventArgs e)
        {
            var selectedRoad = _nowRoads[RoadsList.SelectedRows[0].Index];
            if (selectedRoad != null)
            {
                selectedRoad.RemoveItem();
            }
            UpdateListRoads();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListRoads();
        }

        private void SaveOrCreateRoadBtn_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                _nowRoad.Length = (double)RoadLengthNumupdown.Value;
                _nowRoad.Stop1 = FirstStopCmbbox.SelectedItem as Stop;
                _nowRoad.Stop2 = SecondStopCmbbox.SelectedItem as Stop;
                _nowRoad.IsTwoDir = IsRoadTwoDirChckbox.Checked;
                _nowRoad.Quality = (QualityType)QualityCmbbox.SelectedIndex;
                _nowRoad.RoadTransportType = (TransportType)TransportTypeCmbbox.SelectedIndex;
                _nowRoad.Description = DescriptionTextBox.Text;
                UpdateListRoads();
            }
            else
            {
                MessageBox.Show("Не вистачає даних щоб створити дорогу!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckValues()
        {
            return FirstStopCmbbox.SelectedItem != null && SecondStopCmbbox.SelectedItem != null &&
                   TransportTypeCmbbox.SelectedIndex >= 0 && QualityCmbbox.SelectedIndex >= 0;
        }

        private void RoadsList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (RoadsList.SelectedRows.Count > 0)
            {
                _nowRoad = _nowRoads[RoadsList.SelectedRows[0].Index];
                InitEditorParams();
            }
        }

        private void InitEditorParams()
        {
            TransportTypeCmbbox.SelectedIndex = (int)_nowRoad.RoadTransportType;
            RoadLengthNumupdown.Value = (decimal)_nowRoad.Length;
            FirstStopCmbbox.SelectedItem = _nowRoad.Stop1;
            SecondStopCmbbox.SelectedItem = _nowRoad.Stop2;
            IsRoadTwoDirChckbox.Checked = _nowRoad.IsTwoDir;
            QualityCmbbox.SelectedIndex = (int)_nowRoad.Quality;
            DescriptionTextBox.Text = _nowRoad.Description;
        }

        private void TransportTypeCmbbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FirstStopCmbbox.Items.Clear();
            SecondStopCmbbox.Items.Clear();
            FirstStopCmbbox.ResetText();
            SecondStopCmbbox.ResetText();
            if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Stop> items = new Dictionary<Guid, Stop>();
                if ((TransportType)TransportTypeCmbbox.SelectedIndex == TransportType.Walk)
                {
                    items = Stop.Items;
                }
                else
                {
                    var trType = (TransportType)TransportTypeCmbbox.SelectedIndex;
                    foreach (var item in Stop.Items)
                    {
                        if (item.Value.StopTransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        FirstStopCmbbox.Items.Add(item.Value);
                        SecondStopCmbbox.Items.Add(item.Value);
                    }
                }
            }
        }
    }
}
