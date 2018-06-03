using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormNovoRevisor : Form
    {
        public FormNovoRevisor()
        {
            InitializeComponent();
        }

        private void addRevisor(object sender, EventArgs e)
        {
            if (fieldsCompleted())
            {
                if (!Connection.verifySGBDConnection())
                    return;

                String query = "exec addRevisor @cc = "+boxCC.Text+", @nome = "+boxNome.Text+
                    ", @apelido = "+boxApelido.Text+", @genero = "+ comboBoxGenero.SelectedItem.ToString() + ", @email = "+boxEmail.Text+
                    ", @telefone = "+boxTelefone.Text+", @salario ="+boxSalario.Text;
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
                    throw new Exception("Failed to add revisor to database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Revisor adicionado à base de dados com sucesso");
                    Connection.close();
                    this.Close();
                }
            }
            else
                MessageBox.Show("Por favor preencha todos os campos");
        }

        private bool fieldsCompleted()
        {
            if (boxApelido.Text.Length > 0 && boxCC.Text.Length > 0 && boxEmail.Text.Length > 0 && boxNome.Text.Length > 0 &&
                boxSalario.Text.Length > 0 && boxTelefone.Text.Length > 0 && comboBoxGenero.SelectedItem.ToString().Length > 0)
            {
                if (boxSalario.Text.Contains(","))
                    boxSalario.Text = boxSalario.Text.Replace(",", ".");
                if (comboBoxGenero.SelectedItem.ToString().Contains("@"))
                    comboBoxGenero.SelectedItem = "'" + comboBoxGenero.SelectedItem.ToString() + "'";
                return true;
            }
            else
                return false;
        }
        
    }
}
