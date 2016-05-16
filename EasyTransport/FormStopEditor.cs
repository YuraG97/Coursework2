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
    public partial class FormStopEditor : Form
    {
        private readonly Stop _nowStop;
        public FormStopEditor()
        {
            InitializeComponent();
            InitTransportTypes();
            _nowStop = new Stop();
        }

        public FormStopEditor(Stop editStop)
        {
            InitializeComponent();
            InitTransportTypes();
            _nowStop = editStop;
            CreateNewStop.Text = "Зберегти";
            TransportTypeCmbbox.SelectedIndex = (int) editStop.StopTransportType;
            StopNameTxtbox.Text = editStop.Name;
            StopCoordXNumupdown.Value = (decimal) editStop.Coordinates.X;
            StopCoordYNumupdown.Value = (decimal) editStop.Coordinates.Y;
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
        }

        private void CreateNewStop_Click(object sender, EventArgs e)
        {
            if (TransportTypeCmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Щоб створити маршрут виберіть його тип транспорту!", "Увага", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (TransportTypeCmbbox.SelectedIndex >= 0)
            {
                _nowStop.StopTransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
                var nowPoint = _nowStop.Coordinates;
                nowPoint.X = (float) StopCoordXNumupdown.Value;
                nowPoint.Y = (float) StopCoordYNumupdown.Value;
                _nowStop.Name = StopNameTxtbox.Text;
            }
        }
    }
}
