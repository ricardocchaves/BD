using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormEscolherCliente : Form
    {
        private int currentClient;

        public FormEscolherCliente()
        {
            InitializeComponent();
        }

        private void buttonEscolherCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.Items.Count == 0 | currentClient < 0)
                return;

            Cliente.Escolhido = (Cliente)listBoxClientes.Items[currentClient];

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

        private void loadClientesNome(object sender, EventArgs e)
        {
            if (!Connection.verifySGBDConnection())
                return;

            String boxNome = textBoxSearchCnome.Text;

            // default search: lista todos os clientes na BD
            if (boxNome.Length == 0)
            {
                String query = "exec getCliente @nome=''";
                SqlCommand cmd = new SqlCommand(query, Connection.get());
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxClientes.Items.Clear();

                while (reader.Read())
                {
                    Cliente C = new Cliente();
                    C.CC = reader["CC"].ToString();
                    C.NIF = reader["nif"].ToString();
                    C.UserID = reader["userID"].ToString();
                    C.Nome_proprio = reader["nome_proprio"].ToString();
                    C.Apelido = reader["apelido"].ToString();
                    C.Email = reader["email"].ToString();
                    double tmp;
                    Double.TryParse(reader["saldo"].ToString(), out tmp);
                    C.Saldo = tmp;
                    C.Tel = reader["contacto_telefonico"].ToString();
                    listBoxClientes.Items.Add(C);
                }
            }
            else
            {
                String apelido = "";
                String nome = "";
                if(boxNome.Contains(" "))
                {
                    nome = boxNome.Split(' ')[0];
                    apelido = boxNome.Split(' ')[1];
                }
                else
                {
                    nome = boxNome;
                }
                String query = "exec getCliente @nome='"+nome+"', @apelido='"+apelido+"'";
                SqlCommand cmd = new SqlCommand(query, Connection.get());
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxClientes.Items.Clear();

                while (reader.Read())
                {
                    Cliente C = new Cliente();
                    C.CC = reader["CC"].ToString();
                    C.NIF = reader["nif"].ToString();
                    C.UserID = reader["userID"].ToString();
                    C.Nome_proprio = reader["nome_proprio"].ToString();
                    C.Apelido = reader["apelido"].ToString();
                    C.Email = reader["email"].ToString();
                    double tmp;
                    Double.TryParse(reader["saldo"].ToString(), out tmp);
                    C.Saldo = tmp;
                    C.Tel = reader["contacto_telefonico"].ToString();
                    listBoxClientes.Items.Add(C);
                }
            }

            Connection.close();
            currentClient = 0;
            if (listBoxClientes.Items.Count == 0)
            {
                listBoxClientes.Items.Add("Sem clientes a apresentar");
                currentClient = -1;
            }
            ShowClient();
        }

        private void loadClientesCC(object sender, EventArgs e)
        {
            if (!Connection.verifySGBDConnection())
                return;

            String boxCC = textBoxSearchCcc.Text;

            String query = "exec getCliente @cc='"+boxCC+"'";
            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxClientes.Items.Clear();

            while (reader.Read())
            {
                Cliente C = new Cliente();
                C.CC = reader["CC"].ToString();
                C.NIF = reader["nif"].ToString();
                C.UserID = reader["userID"].ToString();
                C.Nome_proprio = reader["nome_proprio"].ToString();
                C.Apelido = reader["apelido"].ToString();
                C.Email = reader["email"].ToString();
                double tmp;
                Double.TryParse(reader["saldo"].ToString(), out tmp);
                C.Saldo = tmp;
                C.Tel = reader["contacto_telefonico"].ToString();
                listBoxClientes.Items.Add(C);
            }

            Connection.close();
            currentClient = 0;

            if (listBoxClientes.Items.Count == 0)
            {
                listBoxClientes.Items.Add("Sem clientes a apresentar");
                currentClient = -1;
            }

            ShowClient();
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex >= 0)
            {
                currentClient = listBoxClientes.SelectedIndex;
                ShowClient();
            }
        }

        private void ShowClient()
        {
            if (listBoxClientes.Items.Count == 0 | currentClient < 0)
                return;
            Cliente C = (Cliente)listBoxClientes.Items[currentClient];
            textBoxClienteNome.Text = C.Nome_proprio;
            textBoxClienteApelido.Text = C.Apelido;
            textBoxClienteCC.Text = C.CC;
            textBoxClienteEmail.Text = C.Email;
            textBoxClienteNIF.Text = C.NIF;
            textBoxClienteSaldo.Text = C.Saldo.ToString();
            textBoxClienteUserID.Text = C.UserID;
        }

        private void textBoxSearchCnome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadClientesNome(sender, e);
                e.Handled = true;
            }
        }

        private void textBoxSearchCcc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadClientesCC(sender, e);
                e.Handled = true;
            }
        }

        private void FormEscolherCliente_Load(object sender, EventArgs e)
        {

        }

    }
}
