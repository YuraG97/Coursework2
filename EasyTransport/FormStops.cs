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
    public partial class FormStops : Form
    {
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
                TransportTypeCmbbox.Items.Add(trType);
            }
            TransportTypeCmbbox.SelectedIndex = 0;
        }

        private void AddNewStopBtn_Click(object sender, EventArgs e)
        {
            new FormStopEditor().ShowDialog();
            UpdateListStops();
        }

        private void UpdateListStops()
        {
            StopsLstbox.Items.Clear();
            if (TransportTypeCmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Щоб створити зупинку виберіть її тип транспорту!", "Увага", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Stop> items = new Dictionary<Guid, Stop>();
                if (TransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Stop.Items;
                }
                else
                {
                    var trType = (TransportType) (TransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Stop.Items)
                    {
                        if (item.Value.StopTransportType == trType)
                        {
                            items.Add(item.Key,item.Value);
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
        }

        private void ChangeStopBtn_Click(object sender, EventArgs e)
        {
            if (StopsLstbox.SelectedItem != null)
            {
                new FormStopEditor(StopsLstbox.SelectedItem as Stop).ShowDialog();
            }
            UpdateListStops();
        }

        private void CreateCopyStopBtn_Click(object sender, EventArgs e)
        {
            var selectedStop = StopsLstbox.SelectedItem as Stop;
            if (selectedStop != null)
            {
                new Stop(selectedStop.StopTransportType, (decimal) selectedStop.Coordinates.X, (decimal) selectedStop.Coordinates.Y,
                    selectedStop.Name);
            }
            UpdateListStops();
        }

        private void RemoveStopBtn_Click(object sender, EventArgs e)
        {
            var selectedStop = StopsLstbox.SelectedItem as Stop;
            if (selectedStop != null)
            {
                Stop.RemoveItem(selectedStop.Id);
            }
            UpdateListStops();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListStops();
        }
    }
}
