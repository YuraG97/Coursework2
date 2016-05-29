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
            InitSavedParametrs();
        }

        private void InitSavedParametrs()
        {
            SaveOrCreateRoadBtn.Text = "Зберегти";
            TransportTypeCmbbox.SelectedIndex = (int) _nowRoad.RoadTransportType;
            RoadLengthNumupdown.Value = (decimal) _nowRoad.Length;
            FirstStopCmbbox.SelectedItem = _nowRoad.Stop1;
            SecondStopCmbbox.SelectedItem = _nowRoad.Stop2;
            IsRoadTwoDirChckbox.Checked = _nowRoad.IsTwoDir;
            QualityCmbbox.SelectedIndex = (int) _nowRoad.Quality;
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
                _nowRoad.Length = (double) RoadLengthNumupdown.Value;
                _nowRoad.Stop1 = FirstStopCmbbox.SelectedItem as Stop;
                _nowRoad.Stop2 = SecondStopCmbbox.SelectedItem as Stop;
                _nowRoad.IsTwoDir = IsRoadTwoDirChckbox.Checked;
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
            return FirstStopCmbbox.SelectedItem != null && SecondStopCmbbox.SelectedItem != null &&
                   TransportTypeCmbbox.SelectedIndex >= 0 && QualityCmbbox.SelectedIndex >= 0;
        }

        private void TransportTypeCmbbox_SelectedIndexChanged(object sender, EventArgs e)
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
