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
    public partial class FormStops : Form
    {
        private Stop _nowStop;

        public FormStops()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListStops();
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "All", "Bus", "Tramway", "Metro", "Trolleybus" };
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

        private void UpdateListStops()
        {
            StopsLstbox.Items.Clear();
            if (FilterTransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Stop> items = new Dictionary<Guid, Stop>();
                if (FilterTransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Stop.Items;
                }
                else
                {
                    var trType = (TransportType)(FilterTransportTypeCmbbox.SelectedIndex - 1);
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
                        StopsLstbox.Items.Add(item.Value);
                    }
                }
            }
            StopsLstbox.SelectedIndex = StopsLstbox.Items.Count - 1;
        }

        private void AddNewStopBtn_Click(object sender, EventArgs e)
        {
            _nowStop = new Stop();
            UpdateListStops();
            StopsLstbox.SelectedItem = _nowStop;
        }

        private void CreateCopyStopBtn_Click(object sender, EventArgs e)
        {
            var selectedStop = StopsLstbox.SelectedItem as Stop;
            if (selectedStop != null)
            {
                new Stop(selectedStop.StopTransportType, (decimal) selectedStop.Coordinates.X, (decimal) selectedStop.Coordinates.Y,
                    selectedStop.Name + " копія");
            }
            UpdateListStops();
        }

        private void RemoveStopBtn_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("Ви впевнені, що хочете видалити зупинку?", "Увага!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var selectedStop = StopsLstbox.SelectedItem as Stop;
                if (selectedStop != null)
                {
                    selectedStop.RemoveItem();
                }
                UpdateListStops();
            }
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListStops();
        }

        private void InitEditorParams()
        {
            if (StopsLstbox.SelectedItem != null)
            {
                _nowStop = StopsLstbox.SelectedItem as Stop;
                TransportTypeCmbbox.SelectedIndex = (int)_nowStop.StopTransportType;
                StopNameTxtbox.Text = _nowStop.Name;
                StopCoordXNumupdown.Value = (decimal)_nowStop.Coordinates.X;
                StopCoordYNumupdown.Value = (decimal)_nowStop.Coordinates.Y;
                DescriptionTextBox.Text = _nowStop.Description;
            }
            else
            {
                TransportTypeCmbbox.SelectedIndex = -1;
                StopNameTxtbox.Text = "";
                StopCoordXNumupdown.Value = 0;
                StopCoordYNumupdown.Value = 0;
                DescriptionTextBox.Text = "";
            }
        }

        private void SaveStopButton_Click(object sender, EventArgs e)
        {
            _nowStop.StopTransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            _nowStop.Name = StopNameTxtbox.Text;
            var nowPoint = _nowStop.Coordinates;
            nowPoint.X = (float) StopCoordXNumupdown.Value;
            nowPoint.Y = (float) StopCoordYNumupdown.Value;
            _nowStop.Description = DescriptionTextBox.Text;
            MessageBox.Show("Зміни успішно збережено!", "", MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            UpdateListStops();
        }

        private void StopsLstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitEditorParams();
        }

    }
}
