using System;
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
    public partial class FormEscolherCliente : Form
    {
        public FormEscolherCliente()
        {
            InitializeComponent();
        }

        private void buttonEscolherCliente_Click(object sender, EventArgs e)
        {
            FormClientes f = new FormClientes();
            f.Show();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoCliente f = new FormNovoCliente();
            f.Show();
        }
    }
}
