using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TrainsV2.DataTypes;

namespace TrainsV2
{
    public partial class FormClientes : Form
    {
        private String datePicked = "null";
        private int currentFatura;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            int idx = tabControl1.SelectedIndex;
            switch (idx)
            {
                case 0: tabFaturas();
                    break;
                case 1: tabBilhetes();
                    break;
                case 2: tabSaldo();
                    break;
                case 3: tabHorarios();
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelClienteEscolhido.Text = Cliente.Escolhido.ToString();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // TAB: Consultar Faturas
        //
        private void tabFaturas()
        {
            dateTimePickerFatura.CustomFormat = "yyyy-MM-dd";
            currentFatura = 0;
            //loadFaturas();
        }

        private void listBoxFaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFaturas.SelectedIndex >= 0)
            {
                currentFatura = listBoxFaturas.SelectedIndex;
                ShowFatura();
            }
        }

        private void loadFaturas(object sender=null, EventArgs e=null)
        {
            if (!Connection.verifySGBDConnection())
                return;

            String minVal, maxVal, query;
            if(textBoxSearchFaturaMin.Text.Length == 0)
            {
                minVal = "null";
            }else
                minVal = textBoxSearchFaturaMin.Text;

            if (textBoxSearchFaturaMax.Text.Length == 0)
            {
                maxVal = "null";
            } else
                maxVal = textBoxSearchFaturaMax.Text;

            String queryDate = "@data=" + datePicked;
            if (datePicked != "null")
                queryDate = "@data='" + datePicked + "'";

            if(minVal == "null")
            {
                query = "exec getFaturas @cc=" + Cliente.Escolhido.CC.ToString() + ", " + queryDate + ", @valor_max=" + maxVal;
            }else
                query = "exec getFaturas @cc=" + Cliente.Escolhido.CC.ToString() + ", " + queryDate + ", @valor_min=" + minVal + ", @valor_max=" + maxVal;

            if (!Clean.IsClean(query))
            {
                MessageBox.Show(Clean.Err());
                return;
            }

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxFaturas.Items.Clear();

            while (reader.Read())
            {
                Fatura f = new Fatura();
                f.Data = reader["data"].ToString();
                f.Descricao = reader["descricao"].ToString();
                f.Valor = reader["valor"].ToString();
                listBoxFaturas.Items.Add(f);
            }

            currentFatura = 0;

            if (listBoxFaturas.Items.Count == 0)
            {
                listBoxFaturas.Items.Add("Sem faturas a apresentar");
                currentFatura = -1;
            }

            Connection.close();
            ShowFatura();
        }

        private void dateTimePickerFatura_ValueChanged(object sender, EventArgs e)
        {
            datePicked = dateTimePickerFatura.Text;
        }

        private void ShowFatura()
        {
            if (listBoxFaturas.Items.Count == 0 | currentFatura < 0)
                return;
            Fatura f = (Fatura)listBoxFaturas.Items[currentFatura];
            textBoxFaturaData.Text = f.Data;
            textBoxFaturaDescricao.Text = f.Descricao;
            textBoxFaturaValor.Text = f.Valor;
            textBoxFaturaMetodo.Text = "Cartão de Crédito";
        }

        private void buttonResetDate_Click(object sender, EventArgs e)
        {
            datePicked = "null";
        }

        //
        // TAB: Adicionar Saldo
        //
        private double saldoQuant;
        private double saldoNovo;
        private void tabSaldo()
        {
            saldoQuant = 0.00;
            saldoNovo = 0.00;
            showSaldo();
        }

        private void showSaldo(object sender=null, EventArgs e=null)
        {
            textBoxSaldoAtual.Text = Cliente.Escolhido.Saldo.ToString();
            textBoxSaldoQuant.Text = saldoQuant.ToString();
            textBoxSaldoNovo.Text = saldoNovo.ToString();
        }

        public void calcSaldo(object sender=null, EventArgs e=null)
        {
            bool success = Double.TryParse(textBoxSaldoQuant.Text,out saldoQuant);
            if(success == false)
            {
                MessageBox.Show("Introduza uma quantia válida!");
                return;
            }

            saldoNovo = Cliente.Escolhido.Saldo + saldoQuant;
            showSaldo();
        }

        public void addSaldo(object sender = null, EventArgs e = null)
        {
            if (!Connection.verifySGBDConnection())
                return;

            Cliente.Escolhido.Saldo = saldoNovo;
            SqlCommand cmd = new SqlCommand();
            int rows = 0;

            cmd.CommandText = "UPDATE cliente " + "SET saldo = @Saldo WHERE CC = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Saldo", saldoNovo);
            cmd.Parameters.AddWithValue("@id", Cliente.Escolhido.CC);
            cmd.Connection = Connection.get();

            try
            {
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update contact in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
            finally
            {
                if (rows == 1)
                    MessageBox.Show("Saldo alterado com sucesso");
                else
                    MessageBox.Show("Não foi possível alterar o saldo");

                Connection.close();
            }
            showSaldo();
        }

        //
        // TAB: Consultar Bilhetes
        //
        private String EstacaoPartida = "null";
        private String EstacaoChegada = "null";
        private int currentBilhete;
        private void tabBilhetes()
        {
            dateTimePickerBilhetes.CustomFormat = "yyyy-MM-dd";
            currentBilhete = 0;
        }

        private void listBoxBilhetes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBilhetes.SelectedIndex >= 0)
            {
                currentBilhete = listBoxBilhetes.SelectedIndex;
                ShowBilhete();
            }
        }

        private void loadBilhetes(object sender = null, EventArgs e = null)
        {
            if (!Connection.verifySGBDConnection())
                return;

            String queryDate = "@data=" + datePicked;
            if (datePicked != "null")
                queryDate = "@data='" + datePicked + "'";

            String query = "exec getClientBilhetes @cc=" + Cliente.Escolhido.CC + "," + queryDate + ", @estacao_" +
                "partida=" + EstacaoPartida + ", @estacao_chegada=" + EstacaoChegada;

            if (!Clean.IsClean(query))
            {
                MessageBox.Show(Clean.Err());
                return;
            }

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxBilhetes.Items.Clear();

            while (reader.Read())
            {
                Bilhete b = new Bilhete();
                b.BilheteID = reader["bilheteID"].ToString();
                b.Preco = reader["preco"].ToString();
                b.Data = reader["data"].ToString();
                b.ParagemPartida = reader["paragem_partida"].ToString();
                b.ParagemChegada = reader["paragem_chegada"].ToString();
                b.Comboio = reader["lugar_comboio"].ToString();
                b.Carruagem = reader["lugar_carruagem"].ToString();
                b.Lugar = reader["lugar_n"].ToString();
                b.Partida = reader["partida"].ToString();
                b.HoraPartida = reader["hora_partida"].ToString();
                b.Chegada = reader["chegada"].ToString();
                b.HoraChegada = reader["hora_chegada"].ToString();
                listBoxBilhetes.Items.Add(b);
            }

            currentBilhete = 0;

            if (listBoxBilhetes.Items.Count == 0)
            {
                listBoxBilhetes.Items.Add("Sem bilhetes a apresentar");
                currentBilhete = -1;
            }

            Connection.close();
            ShowBilhete();
        }

        private void dateTimePickerBilhete_ValueChanged(object sender, EventArgs e)
        {
            datePicked = dateTimePickerBilhetes.Text;
        }

        private void ShowBilhete()
        {
            if (listBoxBilhetes.Items.Count == 0 | currentBilhete < 0)
                return;

            Bilhete b = (Bilhete)listBoxBilhetes.Items[currentBilhete];
            textBoxBilheteCarr.Text = b.Carruagem;
            textBoxBilheteChegada.Text = b.Chegada;
            textBoxBilheteChegadaHora.Text = b.HoraChegada;
            textBoxBilheteComboio.Text = b.Comboio;
            textBoxBilheteData.Text = b.Data;
            textBoxBilheteLugar.Text = b.Lugar;
            textBoxBilhetePartida.Text = b.Partida;
            textBoxBilhetePartidaHora.Text = b.HoraPartida;
            textBoxBilheteValor.Text = b.Preco;
        }


        //
        // TAB: Consultar Horarios e Comprar bilhete
        //
        private int currentHorario;
        private void tabHorarios()
        {
            currentHorario = 0;

            // fill ComboBoxPartida, ComboBoxChegada
            if (!Connection.verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("select nome from estacao", Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            comboBoxChegada.Items.Clear();
            comboBoxPartida.Items.Clear();

            while (reader.Read())
            {
                String estacao = reader["nome"].ToString();
                comboBoxChegada.Items.Add(estacao);
                comboBoxPartida.Items.Add(estacao);
            }
            Connection.close();
        }

        private void listBoxHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxHorarios.SelectedIndex >= 0)
            {
                currentHorario = listBoxHorarios.SelectedIndex;
                ShowHorario();
            }
        }

        private void ShowHorario()
        {
            if (listBoxHorarios.Items.Count == 0 | currentHorario < 0)
                return;

            Horario h = (Horario)listBoxHorarios.Items[currentHorario];
            textBoxInfoChegada.Text = h.Chegada;
            textBoxInfoChegadaHora.Text = h.HoraChegada;
            textBoxInfoLinha.Text = h.Linha;
            textBoxInfoPartida.Text = h.Partida;
            textBoxInfoPartidaHora.Text = h.HoraPartida;
            textBoxInfoPreco.Text = h.Preco;
        }

        private void loadHorarios(object sender, EventArgs e)
        {
            if (!Connection.verifySGBDConnection())
                return;
            bool PartidaEChegada = true;
            if (comboBoxPartida.SelectedItem == null)
            {
                MessageBox.Show("Partida inválida!");
                return;
            }

            String hora_partida = "null";
            String hora_chegada = "null";
            String chegada = "null";
            String partida = comboBoxPartida.SelectedItem.ToString();

            if (comboBoxChegada.SelectedItem == null)
                PartidaEChegada = false;
            else
                chegada = comboBoxChegada.SelectedItem.ToString();

            if (textBoxSearchHoraPartida.Text.Length > 0)
                hora_partida = textBoxSearchHoraPartida.Text;
            if (textBoxSearchHoraChegada.Text.Length > 0)
                hora_chegada = textBoxSearchHoraChegada.Text;

            String query;
            if (PartidaEChegada)
                query = "exec horariosPC @partida='"+partida+"', @chegada='"+chegada+"', " +
                    "@hora_partida="+hora_partida+", @hora_chegada="+hora_chegada;
            else
                query = "exec horariosC @partida='"+partida+"', @hora_partida="+hora_partida;

            if (!Clean.IsClean(query,"-"))
            {
                MessageBox.Show(Clean.Err());
                return;
            }

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            SqlDataReader reader = cmd.ExecuteReader();
            listBoxHorarios.Items.Clear();

            while (reader.Read())
            {
                Horario h = new Horario();
                h.Chegada = reader["estacaoC"].ToString();
                h.Comboio = reader["comboio"].ToString();
                h.HoraChegada = reader["horaC"].ToString();
                h.HoraPartida = reader["horaP"].ToString();
                h.Linha = reader["linha"].ToString();
                h.ParagemChegada = reader["id2"].ToString();
                h.ParagemPartida = reader["id1"].ToString();
                h.Partida = reader["estacaoP"].ToString();
                h.Viagem = reader["viagem"].ToString();
                h.Preco = reader["preco"].ToString();
                listBoxHorarios.Items.Add(h);
            }

            currentHorario = 0;

            if (listBoxHorarios.Items.Count == 0)
            {
                listBoxBilhetes.Items.Add("Sem horarios a apresentar");
                currentHorario = -1;
            }

            Connection.close();
            ShowHorario();
        }

        void comprarBilhete(object sender, EventArgs e)
        {
            String carr = textBoxInfoCarruagem.Text;
            String lugar = textBoxInfoLugar.Text;
            if (carr.Length == 0 || lugar.Length == 0)
            {
                MessageBox.Show("Por favor preencha todos os campos!");
                return;
            }

            if (!Connection.verifySGBDConnection())
                return;

            Horario h = (Horario)listBoxHorarios.Items[currentHorario];

            String query = "declare @tmp viagem_array; insert into @tmp values("+h.Viagem+",'"+
                h.Partida+"','"+h.Chegada+"',"+carr+","+lugar+");exec comprar_bilhete " +
                "@cc="+Cliente.Escolhido.CC+",@viagens=@tmp,@latitude=40.64528,@longitude=-8.639841,@metodo='Compra com saldo'," +
                "@data='"+ DateTime.Now.ToString("yyyy-MM-dd") +"'";

            if (!Clean.IsClean(query,"-"))
            {
                MessageBox.Show(Clean.Err());
                MessageBox.Show(query);
                return;
            }

            SqlCommand cmd = new SqlCommand(query, Connection.get());
            //cmd.CommandType = System.Data.CommandType.StoredProcedure;

            var returnParameter = cmd.Parameters.Add("@ReturnVal", System.Data.SqlDbType.Int);
            returnParameter.Direction = System.Data.ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            
            int result = (int)returnParameter.Value;
            if (result == 1)
            {
                MessageBox.Show("Lugar indisponível!");
            }else if (result == 2)
            {
                MessageBox.Show("Saldo insuficiente!");
            }else
            {
                MessageBox.Show("Bilhete comprado com sucesso!");
            }
            Connection.close();
        }
    }
}
