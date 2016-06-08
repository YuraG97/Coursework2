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
        public FormTransports()
        {
            InitializeComponent();
            InitTransportTypes();
            UpdateListTransports();
        }

        private void UpdateListTransports()
        {
            TransportsLstbox.Items.Clear();
            if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                Dictionary<Guid, Transport> items = new Dictionary<Guid, Transport>();
                if (TransportTypeCmbbox.SelectedIndex == 0)
                {
                    items = Transport.Items;
                }
                else
                {
                    var trType = (TransportType)(TransportTypeCmbbox.SelectedIndex - 1);
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
                TransportTypeCmbbox.Items.Add(trType);
            }
            TransportTypeCmbbox.SelectedIndex = 0;
        }

        private void AddNewTransportBtn_Click(object sender, EventArgs e)
        {
            new FormTransportEditor().ShowDialog();
            UpdateListTransports();
        }

        private void ChangeTransportBtn_Click(object sender, EventArgs e)
        {
            if (TransportsLstbox.SelectedItem != null)
            {
                new FormTransportEditor(TransportsLstbox.SelectedItem as Transport).ShowDialog();
            }
            UpdateListTransports();
        }

        private void CreateCopyTransportBtn_Click(object sender, EventArgs e)
        {
            var selectedTransport = TransportsLstbox.SelectedItem as Transport;
            if (selectedTransport != null)
            {
                new Transport(selectedTransport.SerieName, selectedTransport.SerialNumber, selectedTransport.Mark,
                    selectedTransport.TransportType);
            }
            UpdateListTransports();
        }

        private void RemoveTransportBtn_Click(object sender, EventArgs e)
        {
            var selectedTransport = TransportsLstbox.SelectedItem as Transport;
            if (selectedTransport != null)
            {
                Transport.RemoveItem(selectedTransport.Id);
            }
            UpdateListTransports();
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListTransports();
        }
    }
}
