﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorldGIS
{
    public partial class FrmSetSelectLevel : Form
    {
        public string m_strTerrainExtra;
        public FrmSetSelectLevel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m_strTerrainExtra = textBox2.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void ExtraTerrain_Load(object sender, EventArgs e)
        {
           textBox2.Text =  m_strTerrainExtra;
        }
    }
}
