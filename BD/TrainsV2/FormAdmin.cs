using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void revisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoRevisor f = new FormNovoRevisor();
            f.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0:
                    tabRevisores();
                    break;
                case 1:
                    tabComboios();
                    break;
            }
        }

        //
        // TAB: Revisores
        //
        private int currentRevisor;
        private String boxNome, boxApelido, boxCC, boxSalarioMin, boxSalarioMax;
        private void tabRevisores()
        {
            currentRevisor = 0;
        }

        private void listBoxRevisores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRevisores.SelectedIndex >= 0)
            {
                currentRevisor = listBoxRevisores.SelectedIndex;
                ShowRevisor();
            }
        }

        private void loadRevisores(object sender=null, EventArgs e=null)
        {
            if (!Connection.verifySGBDConnection())
                return;

            boxNome = textBoxSearchRevisorNome.Text;
            boxApelido = "null";
            if (boxNome.Length == 0)
                boxNome = "null";
            else if (boxNome.Contains(" "))
            {
                String[] tmp = boxNome.Split(' ');
                boxNome = tmp[0];
                boxApelido = tmp[1];
            }
            boxCC = textBoxSearchRevisorCC.Text;
            if (boxCC.Length == 0)
                boxCC = "null";
            boxSalarioMin = textBoxSearchRevisorMin.Text;
            if (boxSalarioMin.Length == 0)
                boxSalarioMin = "null";
            boxSalarioMax = textBoxSearchRevisorMax.Text;
            if (boxSalarioMax.Length == 0)
                boxSalarioMax = "null";

            String query = "exec getRevisor @cc=" + boxCC+ ", @nome="+boxNome+", @apelido="+boxApelido+", " +
                "@salario_min="+boxSalarioMin+", @salario_max="+boxSalarioMax;

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxRevisores.Items.Clear();

            while (reader.Read())
            {
                Revisor r = new Revisor();
                r.Apelido = reader["apelido"].ToString();
                r.Cc = reader["CC"].ToString();
                r.Email = reader["email"].ToString();
                r.NomeProprio = reader["nome_proprio"].ToString();
                r.Salario = reader["salario"].ToString();
                r.Telefone = reader["telefone"].ToString();
                listBoxRevisores.Items.Add(r);
            }

            currentRevisor = 0;

            if (listBoxRevisores.Items.Count == 0)
            {
                listBoxRevisores.Items.Add("Sem revisores a apresentar");
                currentRevisor = -1;
            }

            Connection.close();
            ShowRevisor();
        }

        private void ShowRevisor()
        {
            if (listBoxRevisores.Items.Count == 0 | currentRevisor < 0)
                return;
            Revisor r = (Revisor)listBoxRevisores.Items[currentRevisor];
            textBoxRevisorApelido.Text = r.Apelido;
            textBoxRevisorCC.Text = r.Cc;
            textBoxRevisorEmail.Text = r.Email;
            textBoxRevisorNome.Text = r.NomeProprio;
            textBoxRevisorSalario.Text = r.Salario;
            textBoxRevisorTel.Text = r.Telefone;
        }

        private void apagarRevisor(object sender, EventArgs e)
        {
            if (listBoxRevisores.Items.Count == 0 | currentRevisor < 0)
                return;
            Revisor r = (Revisor)listBoxRevisores.Items[currentRevisor];

            if (!Connection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("exec deleteRevisor @cc=" + r.Cc, Connection.get());

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete revisor in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                Connection.close();
            }

            MessageBox.Show("Revisor '" + r.ToString() + "' apagado com sucesso");
            loadRevisores();
        }

        //
        // TAB: Comboios
        //
        private int currentComboio;

        private String boxFabricante, boxTipo, boxID;

        private void tabComboios()
        {
            currentComboio = 0;
        }

        private void listBoxComboios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxComboios.SelectedIndex >= 0)
            {
                currentComboio = listBoxComboios.SelectedIndex;
                ShowComboio();
            }
        }

        private void loadComboios(object sender = null, EventArgs e = null)
        {
            if (!Connection.verifySGBDConnection())
                return;

            boxFabricante = textBoxSearchCombFabricante.Text;
            boxTipo = textBoxSearchCombTipo.Text;
            boxID = textBoxSearchCombID.Text;
            if (boxFabricante.Length == 0)
                boxFabricante = "null";
            if (boxTipo.Length == 0)
                boxTipo = "null";
            if (boxID.Length == 0)
                boxID = "null";

            String query = "exec getComboios @id="+boxID+", @tipo="+boxTipo+", @fabricante="+boxFabricante;

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxComboios.Items.Clear();

            while (reader.Read())
            {
                Comboio c = new Comboio();
                c.Carruagens = reader["num_carruagens"].ToString();
                c.Fabricante = reader["fabricante"].ToString();
                c.Id = reader["id_comboio"].ToString();
                c.Lugares = reader["num_lug_comboio"].ToString();
                c.Tipo = reader["tipo"].ToString();
                listBoxComboios.Items.Add(c);
            }

            currentComboio = 0;

            if (listBoxComboios.Items.Count == 0)
            {
                listBoxComboios.Items.Add("Sem comboios a apresentar");
                currentComboio = -1;
            }

            Connection.close();
            ShowComboio();
        }

        private void ShowComboio()
        {
            if (listBoxComboios.Items.Count == 0 | currentComboio < 0)
                return;
            Comboio c = (Comboio)listBoxComboios.Items[currentComboio];
            textBoxCombCapacidade.Text = c.Lugares;
            textBoxCombCarruagens.Text = c.Carruagens;
            textBoxCombFabricante.Text = c.Fabricante;
            textBoxCombID.Text = c.Id;
            textBoxCombTipo.Text = c.Tipo;
        }

    }
}
