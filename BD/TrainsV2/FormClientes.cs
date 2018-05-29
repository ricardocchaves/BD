using System;
using System.Windows.Forms;

namespace TrainsV2
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            FormSaldo f = new FormSaldo();
            f.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoCliente f = new FormNovoCliente();
            f.Show();
        }

        private void faturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoFatura f = new FormNovoFatura();
            f.Show();
        }

    }
}
