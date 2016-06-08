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
    public partial class FormTransportEditor : Form
    {
        private readonly Transport _nowTransport;

        public FormTransportEditor()
        {
            InitializeComponent();
            _nowTransport = new Transport();
            InitTransportTypes();
        }

        public FormTransportEditor(Transport transport)
        {
            InitializeComponent();
            _nowTransport = transport;
            InitTransportTypes();
            InitSavedParametrs();
        }

        private void InitSavedParametrs()
        {
            CreateNewTransport.Text = "Зберегти";
            TransportTypeCmbbox.SelectedIndex = (int) _nowTransport.TransportType;
            MarkTxtbox.Text = _nowTransport.Mark;
            SerieTxtbox.Text = _nowTransport.SerieName;
            SerialNumberTxtbox.Text = _nowTransport.SerialNumber;
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
        }

        private void CreateNewTransport_Click(object sender, EventArgs e)
        {
            _nowTransport.TransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            _nowTransport.Mark = MarkTxtbox.Text;
            _nowTransport.SerieName = SerieTxtbox.Text;
            _nowTransport.SerialNumber = SerialNumberTxtbox.Text;
        }
    }
}
