using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormNovoCliente : Form
    {
        public FormNovoCliente()
        {
            InitializeComponent();
        }

        private void addCliente(object sender, EventArgs e)
        {
            if (fieldsCompleted())
            {
                if (!Connection.verifySGBDConnection())
                    return;

                String query = "exec addCliente @cc = " + boxCC.Text + ", @nome = " + boxNome.Text + 
                    ", @apelido = " + boxApelido.Text + ", @genero = " + comboGenero.SelectedItem.ToString() + 
                    ", @email = " + boxEmail.Text + ", @telefone = " + boxTel.Text + ", @nif = " + boxNIF.Text + 
                    ", @userId = " + boxUserID.Text + ", @password = " + boxPass1.Text + ",@cartao = " + boxCartaoCredito.Text;
                if (!Clean.IsClean(query))
                {
                    MessageBox.Show(Clean.Err());
                    return;
                }
                SqlCommand cmd = new SqlCommand(query, Connection.get());

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to add client to database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Cliente adicionado à base de dados com sucesso");
                    Connection.close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Por favor preencha todos os campos");
        }

        private bool fieldsCompleted()
        {
            if (boxApelido.Text.Length > 0 && boxCartaoCredito.Text.Length > 0 && boxCC.Text.Length > 0 &&
                boxEmail.Text.Length > 0 && boxNIF.Text.Length > 0 && boxNome.Text.Length > 0 && checkPass() &&
                boxTel.Text.Length > 0 && boxUserID.Text.Length > 0 && comboGenero.SelectedItem.ToString().Length > 0)
            {
                if (boxEmail.Text.Contains("@"))
                    boxEmail.Text = "'" + boxEmail.Text + "'";
                boxCartaoCredito.Text = boxCartaoCredito.Text.Replace("-", " ");
                boxCartaoCredito.Text = boxCartaoCredito.Text.Replace("/", " ");
                boxCartaoCredito.Text = boxCartaoCredito.Text.Replace(".", " ");
                boxCartaoCredito.Text = boxCartaoCredito.Text.Replace(",", " ");
                boxCartaoCredito.Text = "'" + boxCartaoCredito.Text + "'";
                return true;
            }
            else
                return false;
        }

        private bool checkPass()
        {
            bool ret = true;
            if (boxPass1.Text.Length == 0 || boxPass2.Text.Length == 0)
                ret = false;
            if (boxPass1.Text.CompareTo(boxPass2.Text) != 0)
                ret = false;
            return ret;
        }
    }
}
