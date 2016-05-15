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
            comboBox1.SelectedIndex = (int) editStop.StopTransportType;
            textBox1.Text = editStop.Name;
            numericUpDown1.Value = (decimal) editStop.Coordinates.X;
            numericUpDown2.Value = (decimal) editStop.Coordinates.Y;
        }

        private void InitTransportTypes()
        {
            string[] transpTypes = { "Bus", "Tramway", "Metro", "Trolleybus" };
            foreach (var trType in transpTypes)
            {
                comboBox1.Items.Add(trType);
            }
        }

        private void CreateNewStop_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Щоб створити маршрут виберіть його тип транспорту!", "Увага", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (comboBox1.SelectedIndex >= 0)
            {
                _nowStop.StopTransportType = (TransportType) comboBox1.SelectedIndex;
                var nowPoint = _nowStop.Coordinates;
                nowPoint.X = (float) numericUpDown1.Value;
                nowPoint.Y = (float) numericUpDown2.Value;
                _nowStop.Name = textBox1.Text;
            }
        }
    }
}
