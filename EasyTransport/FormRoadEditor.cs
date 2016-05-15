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
    public partial class FormRoadEditor : Form
    {
        private readonly Road _nowRoad;
        public FormRoadEditor()
        {
            InitializeComponent();
            InitCmbbox();
            _nowRoad = new Road();
        }

        public FormRoadEditor(Road editRoad)
        {
            InitializeComponent();
            InitCmbbox();
            _nowRoad = editRoad;
            SaveOrCreateRoadBtn.Text = "Зберегти";
            TransportTypeCmbbox.SelectedIndex = (int) editRoad.RoadTransportType;
            numericUpDown1.Value = (decimal) editRoad.Length;
            comboBox2.SelectedItem = editRoad.Stop1;
            comboBox3.SelectedItem = editRoad.Stop2;
            checkBox1.Checked = editRoad.IsTwoDir;
            QualityCmbbox.SelectedIndex = (int) editRoad.Quality;
        }

        private void InitCmbbox()
        {
            string[] transpTypes = {"Bus", "Tramway", "Metro", "Trolleybus", "Walk"};
            string[] qualityTypes = {"Good", "Middle", "Bad"};
            
            foreach (var trType in transpTypes)
            {
                TransportTypeCmbbox.Items.Add(trType);
            }
            foreach (var qualityType in qualityTypes)
            {
                QualityCmbbox.Items.Add(qualityType);
            }
        }

        private void SaveOrCreateRoadBtn_Click(object sender, EventArgs e)
        {
            if (CheckValues())
            {
                _nowRoad.Length = (double) numericUpDown1.Value;
                _nowRoad.Stop1 = comboBox2.SelectedItem as Stop;
                _nowRoad.Stop2 = comboBox3.SelectedItem as Stop;
                _nowRoad.IsTwoDir = checkBox1.Checked;
                _nowRoad.Quality = (QualityType) QualityCmbbox.SelectedIndex;
                _nowRoad.RoadTransportType = (TransportType) TransportTypeCmbbox.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Не вистачає даних щоб створити дорогу!");
            }
        }

        private bool CheckValues()
        {
            return comboBox2.SelectedItem != null && comboBox3.SelectedItem != null &&
                   TransportTypeCmbbox.SelectedIndex >= 0 && QualityCmbbox.SelectedIndex >= 0;
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.ResetText();
            comboBox3.ResetText();
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
                        comboBox2.Items.Add(item.Value);
                        comboBox3.Items.Add(item.Value);
                    }
                }
            }
        }
    }
}
