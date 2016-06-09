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
    public partial class FormTransports : Form
    {
        private Transport _nowTransport;

        public FormTransports()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListTransports();
        }

        private void UpdateListTransports()
        {
            TransportsLstbox.Items.Clear();
            if (FilterTransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Transport> items = new Dictionary<Guid, Transport>();
                if (FilterTransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Transport.Items;
                }
                else
                {
                    var trType = (TransportType)(FilterTransportTypeCmbbox.SelectedIndex - 1);
                    foreach (var item in Transport.Items)
                    {
                        if (item.Value.TransportType == trType)
                        {
                            items.Add(item.Key, item.Value);
                        }
                    }
                }
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        TransportsLstbox.Items.Add(item.Value);
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
                if (trType != "All")
                {
                    TransportTypeCmbbox.Items.Add(trType);
                }
            }
            FilterTransportTypeCmbbox.SelectedIndex = 0;
        }

        private void AddNewTransportBtn_Click(object sender, EventArgs e)
        {
            _nowTransport = new Transport();
            TransportsLstbox.SelectedIndex = TransportsLstbox.Items.Count - 1;
            //InitTransportTypes();
            UpdateListTransports();
            UpdateTransportView();
        }

        private void CreateCopyTransportBtn_Click(object sender, EventArgs e)
        {
            var selectedTransport = TransportsLstbox.SelectedItem as Transport;
            if (selectedTransport != null)
            {
                new Transport(selectedTransport.SerieName, selectedTransport.SerialNumber, selectedTransport.Mark,
                    selectedTransport.TransportType, selectedTransport.AverageSpeed, selectedTransport.Description);
            }
            UpdateListTransports();
        }

        private void RemoveTransportBtn_Click(object sender, EventArgs e)
        {
            var selectedTransport = TransportsLstbox.SelectedItem as Transport;
            if (selectedTransport != null)
            {
                selectedTransport.RemoveItem();
            }
            UpdateListTransports();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListTransports();
        }

        private void SaveTransport_Click(object sender, EventArgs e)
        {
            _nowTransport.TransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            _nowTransport.Mark = MarkTxtbox.Text;
            _nowTransport.SerieName = SerieTxtbox.Text;
            _nowTransport.SerialNumber = SerialNumberTxtbox.Text;
            _nowTransport.AverageSpeed = (double) AverageSpeedNumUpDown.Value;
            _nowTransport.Description = DescriptionTextbox.Text;
        }

        private void TransportsLstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _nowTransport = TransportsLstbox.SelectedItem as Transport;
            if (_nowTransport != null)
            {
                UpdateTransportView();
            }
        }

        private void UpdateTransportView()
        {
            TransportTypeCmbbox.SelectedIndex = (int)_nowTransport.TransportType;
            MarkTxtbox.Text = _nowTransport.Mark;
            SerieTxtbox.Text = _nowTransport.SerieName;
            SerialNumberTxtbox.Text = _nowTransport.SerialNumber;
            AverageSpeedNumUpDown.Value = (decimal) _nowTransport.AverageSpeed;
            DescriptionTextbox.Text = _nowTransport.Description;
        }
    }
}
