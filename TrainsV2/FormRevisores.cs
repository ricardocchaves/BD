﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainsV2
{
    public partial class FormRevisores : Form
    {
        public FormRevisores()
        {
            InitializeComponent();
        }

        private void novoRevisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoRevisor f = new FormNovoRevisor();
            f.Show();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
