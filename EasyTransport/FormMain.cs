﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void проПрограмуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FormAbout().Show();
        }

        //private void FormMain_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show(new Stop().ToString());
        //}
    }
}
