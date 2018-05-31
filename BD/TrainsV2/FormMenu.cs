using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            var frm = new FormEscolherCliente();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FormAdmin();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.verifySGBDConnection();
            }catch(Exception)
            {
                DialogResult dialogAnswer = MessageBox.Show("Não foi possível abrir a ligação! Gostaria de tentar usar uma ligação local?", "Erro", MessageBoxButtons.YesNo);
                if (dialogAnswer == DialogResult.Yes)
                {
                    try
                    {
                        Connection.verifySGBDConnection("local");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não foi possível estabelecer ligação à base de dados local!");
                        this.Close();
                    }
                    
                }
                else
                    this.Close();
            }
        }
    }
}
