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
                        bool repeat = true;
                        MessageBox.Show("Não foi possível estabelecer ligação à base de dados local!");
                        while (repeat)
                        {
                            DialogResult dialogAnswer2 = MessageBox.Show("Não foi possível abrir a ligação! Gostaria de personalizar a ligação?", "Erro", MessageBoxButtons.YesNo);
                            if (dialogAnswer2 == DialogResult.Yes)
                            {
                                try
                                {
                                    String connStr = Prompt.ShowDialog("Introduza a connectionString a usar.", "Connection String", "Data Source = tcp:193.136.175.33\\SQLSERVER2012,8293; Initial Catalog=P3G2; User ID=admin; Password=admin");
                                    Connection.verifySGBDConnection(connStr);
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Tente novamente");
                                }
                            }
                            else
                            {
                                repeat = false;
                                this.Close();
                            }
                        }
                    }
                    
                }
                else
                    this.Close();
            }
        }
    }
}
