namespace TrainsV2
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonApagarRevisor = new System.Windows.Forms.Button();
            this.textBoxRevisorSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRevisorTel = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxRevisorEmail = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxRevisorCC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxRevisorApelido = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxRevisorNome = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBoxSearchRevisorMin = new System.Windows.Forms.TextBox();
            this.textBoxSearchRevisorMax = new System.Windows.Forms.TextBox();
            this.textBoxSearchRevisorCC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchRevisor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRevisores = new System.Windows.Forms.ListBox();
            this.textBoxSearchRevisorNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCombCapacidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCombCarruagens = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCombTipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCombFabricante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCombID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxSearchCombTipo = new System.Windows.Forms.TextBox();
            this.buttonSearchComboio = new System.Windows.Forms.Button();
            this.textBoxSearchCombID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBoxComboios = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSearchCombFabricante = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.novoClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.voltarToolStripMenuItem.Text = "< Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revisorToolStripMenuItem});
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.novoClienteToolStripMenuItem.Text = "Novo";
            // 
            // revisorToolStripMenuItem
            // 
            this.revisorToolStripMenuItem.Name = "revisorToolStripMenuItem";
            this.revisorToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.revisorToolStripMenuItem.Text = "Revisor";
            this.revisorToolStripMenuItem.Click += new System.EventHandler(this.revisorToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 313);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Revisores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 251);
            this.panel7.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonApagarRevisor);
            this.panel4.Controls.Add(this.textBoxRevisorSalario);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBoxRevisorTel);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.textBoxRevisorEmail);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.textBoxRevisorCC);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.textBoxRevisorApelido);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.textBoxRevisorNome);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Location = new System.Drawing.Point(354, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(402, 223);
            this.panel4.TabIndex = 5;
            // 
            // buttonApagarRevisor
            // 
            this.buttonApagarRevisor.Location = new System.Drawing.Point(7, 154);
            this.buttonApagarRevisor.Name = "buttonApagarRevisor";
            this.buttonApagarRevisor.Size = new System.Drawing.Size(121, 66);
            this.buttonApagarRevisor.TabIndex = 18;
            this.buttonApagarRevisor.Text = "ELIMINAR REVISOR";
            this.buttonApagarRevisor.UseVisualStyleBackColor = true;
            this.buttonApagarRevisor.Click += new System.EventHandler(this.apagarRevisor);
            // 
            // textBoxRevisorSalario
            // 
            this.textBoxRevisorSalario.Location = new System.Drawing.Point(59, 113);
            this.textBoxRevisorSalario.Name = "textBoxRevisorSalario";
            this.textBoxRevisorSalario.ReadOnly = true;
            this.textBoxRevisorSalario.Size = new System.Drawing.Size(124, 20);
            this.textBoxRevisorSalario.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salário";
            // 
            // textBoxRevisorTel
            // 
            this.textBoxRevisorTel.Location = new System.Drawing.Point(59, 80);
            this.textBoxRevisorTel.Name = "textBoxRevisorTel";
            this.textBoxRevisorTel.ReadOnly = true;
            this.textBoxRevisorTel.Size = new System.Drawing.Size(124, 20);
            this.textBoxRevisorTel.TabIndex = 15;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Telefone";
            // 
            // textBoxRevisorEmail
            // 
            this.textBoxRevisorEmail.Location = new System.Drawing.Point(212, 52);
            this.textBoxRevisorEmail.Name = "textBoxRevisorEmail";
            this.textBoxRevisorEmail.ReadOnly = true;
            this.textBoxRevisorEmail.Size = new System.Drawing.Size(187, 20);
            this.textBoxRevisorEmail.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(175, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "email";
            // 
            // textBoxRevisorCC
            // 
            this.textBoxRevisorCC.Location = new System.Drawing.Point(40, 52);
            this.textBoxRevisorCC.Name = "textBoxRevisorCC";
            this.textBoxRevisorCC.ReadOnly = true;
            this.textBoxRevisorCC.Size = new System.Drawing.Size(124, 20);
            this.textBoxRevisorCC.TabIndex = 11;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "CC";
            // 
            // textBoxRevisorApelido
            // 
            this.textBoxRevisorApelido.Location = new System.Drawing.Point(248, 25);
            this.textBoxRevisorApelido.Name = "textBoxRevisorApelido";
            this.textBoxRevisorApelido.ReadOnly = true;
            this.textBoxRevisorApelido.Size = new System.Drawing.Size(151, 20);
            this.textBoxRevisorApelido.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(200, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Apelido";
            // 
            // textBoxRevisorNome
            // 
            this.textBoxRevisorNome.Location = new System.Drawing.Point(40, 25);
            this.textBoxRevisorNome.Name = "textBoxRevisorNome";
            this.textBoxRevisorNome.ReadOnly = true;
            this.textBoxRevisorNome.Size = new System.Drawing.Size(154, 20);
            this.textBoxRevisorNome.TabIndex = 7;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Nome";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 2);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Detalhes";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label45);
            this.panel8.Controls.Add(this.label44);
            this.panel8.Controls.Add(this.textBoxSearchRevisorMin);
            this.panel8.Controls.Add(this.textBoxSearchRevisorMax);
            this.panel8.Controls.Add(this.textBoxSearchRevisorCC);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.buttonSearchRevisor);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.listBoxRevisores);
            this.panel8.Controls.Add(this.textBoxSearchRevisorNome);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(349, 240);
            this.panel8.TabIndex = 3;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(175, 101);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(26, 13);
            this.label45.TabIndex = 24;
            this.label45.Text = "max";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(66, 100);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(23, 13);
            this.label44.TabIndex = 23;
            this.label44.Text = "min";
            // 
            // textBoxSearchRevisorMin
            // 
            this.textBoxSearchRevisorMin.Location = new System.Drawing.Point(67, 79);
            this.textBoxSearchRevisorMin.Name = "textBoxSearchRevisorMin";
            this.textBoxSearchRevisorMin.Size = new System.Drawing.Size(93, 20);
            this.textBoxSearchRevisorMin.TabIndex = 22;
            // 
            // textBoxSearchRevisorMax
            // 
            this.textBoxSearchRevisorMax.Location = new System.Drawing.Point(177, 79);
            this.textBoxSearchRevisorMax.Name = "textBoxSearchRevisorMax";
            this.textBoxSearchRevisorMax.Size = new System.Drawing.Size(93, 20);
            this.textBoxSearchRevisorMax.TabIndex = 21;
            // 
            // textBoxSearchRevisorCC
            // 
            this.textBoxSearchRevisorCC.Location = new System.Drawing.Point(68, 51);
            this.textBoxSearchRevisorCC.Name = "textBoxSearchRevisorCC";
            this.textBoxSearchRevisorCC.Size = new System.Drawing.Size(277, 20);
            this.textBoxSearchRevisorCC.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "CC";
            // 
            // buttonSearchRevisor
            // 
            this.buttonSearchRevisor.Location = new System.Drawing.Point(276, 77);
            this.buttonSearchRevisor.Name = "buttonSearchRevisor";
            this.buttonSearchRevisor.Size = new System.Drawing.Size(69, 23);
            this.buttonSearchRevisor.TabIndex = 17;
            this.buttonSearchRevisor.Text = "SEARCH";
            this.buttonSearchRevisor.UseVisualStyleBackColor = true;
            this.buttonSearchRevisor.Click += new System.EventHandler(this.loadRevisores);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salário";
            // 
            // listBoxRevisores
            // 
            this.listBoxRevisores.FormattingEnabled = true;
            this.listBoxRevisores.Location = new System.Drawing.Point(7, 116);
            this.listBoxRevisores.Name = "listBoxRevisores";
            this.listBoxRevisores.Size = new System.Drawing.Size(338, 121);
            this.listBoxRevisores.TabIndex = 9;
            this.listBoxRevisores.SelectedIndexChanged += new System.EventHandler(this.listBoxRevisores_SelectedIndexChanged);
            // 
            // textBoxSearchRevisorNome
            // 
            this.textBoxSearchRevisorNome.Location = new System.Drawing.Point(68, 24);
            this.textBoxSearchRevisorNome.Name = "textBoxSearchRevisorNome";
            this.textBoxSearchRevisorNome.Size = new System.Drawing.Size(277, 20);
            this.textBoxSearchRevisorNome.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pesquisa de Revisor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(776, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Comboios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxCombCapacidade);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxCombCarruagens);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxCombTipo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxCombFabricante);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxCombID);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(359, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 110);
            this.panel1.TabIndex = 7;
            // 
            // textBoxCombCapacidade
            // 
            this.textBoxCombCapacidade.Location = new System.Drawing.Point(247, 69);
            this.textBoxCombCapacidade.Name = "textBoxCombCapacidade";
            this.textBoxCombCapacidade.ReadOnly = true;
            this.textBoxCombCapacidade.Size = new System.Drawing.Size(56, 20);
            this.textBoxCombCapacidade.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Capacidade";
            // 
            // textBoxCombCarruagens
            // 
            this.textBoxCombCarruagens.Location = new System.Drawing.Point(85, 69);
            this.textBoxCombCarruagens.Name = "textBoxCombCarruagens";
            this.textBoxCombCarruagens.ReadOnly = true;
            this.textBoxCombCarruagens.Size = new System.Drawing.Size(41, 20);
            this.textBoxCombCarruagens.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Carruagens";
            // 
            // textBoxCombTipo
            // 
            this.textBoxCombTipo.Location = new System.Drawing.Point(47, 39);
            this.textBoxCombTipo.Name = "textBoxCombTipo";
            this.textBoxCombTipo.ReadOnly = true;
            this.textBoxCombTipo.Size = new System.Drawing.Size(298, 20);
            this.textBoxCombTipo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tipo";
            // 
            // textBoxCombFabricante
            // 
            this.textBoxCombFabricante.Location = new System.Drawing.Point(170, 8);
            this.textBoxCombFabricante.Name = "textBoxCombFabricante";
            this.textBoxCombFabricante.ReadOnly = true;
            this.textBoxCombFabricante.Size = new System.Drawing.Size(175, 20);
            this.textBoxCombFabricante.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Fabricante";
            // 
            // textBoxCombID
            // 
            this.textBoxCombID.Location = new System.Drawing.Point(47, 8);
            this.textBoxCombID.Name = "textBoxCombID";
            this.textBoxCombID.ReadOnly = true;
            this.textBoxCombID.Size = new System.Drawing.Size(41, 20);
            this.textBoxCombID.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxSearchCombTipo);
            this.panel3.Controls.Add(this.buttonSearchComboio);
            this.panel3.Controls.Add(this.textBoxSearchCombID);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.listBoxComboios);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.textBoxSearchCombFabricante);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 228);
            this.panel3.TabIndex = 6;
            // 
            // textBoxSearchCombTipo
            // 
            this.textBoxSearchCombTipo.Location = new System.Drawing.Point(61, 56);
            this.textBoxSearchCombTipo.Name = "textBoxSearchCombTipo";
            this.textBoxSearchCombTipo.Size = new System.Drawing.Size(284, 20);
            this.textBoxSearchCombTipo.TabIndex = 13;
            // 
            // buttonSearchComboio
            // 
            this.buttonSearchComboio.Location = new System.Drawing.Point(271, 88);
            this.buttonSearchComboio.Name = "buttonSearchComboio";
            this.buttonSearchComboio.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchComboio.TabIndex = 12;
            this.buttonSearchComboio.Text = "SEARCH";
            this.buttonSearchComboio.UseVisualStyleBackColor = true;
            this.buttonSearchComboio.Click += new System.EventHandler(this.loadComboios);
            // 
            // textBoxSearchCombID
            // 
            this.textBoxSearchCombID.Location = new System.Drawing.Point(61, 90);
            this.textBoxSearchCombID.Name = "textBoxSearchCombID";
            this.textBoxSearchCombID.Size = new System.Drawing.Size(203, 20);
            this.textBoxSearchCombID.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "ID";
            // 
            // listBoxComboios
            // 
            this.listBoxComboios.FormattingEnabled = true;
            this.listBoxComboios.Location = new System.Drawing.Point(7, 125);
            this.listBoxComboios.Name = "listBoxComboios";
            this.listBoxComboios.Size = new System.Drawing.Size(338, 95);
            this.listBoxComboios.TabIndex = 9;
            this.listBoxComboios.SelectedIndexChanged += new System.EventHandler(this.listBoxComboios_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tipo";
            // 
            // textBoxSearchCombFabricante
            // 
            this.textBoxSearchCombFabricante.Location = new System.Drawing.Point(94, 24);
            this.textBoxSearchCombFabricante.Name = "textBoxSearchCombFabricante";
            this.textBoxSearchCombFabricante.Size = new System.Drawing.Size(251, 20);
            this.textBoxSearchCombFabricante.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Fabricante";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Pesquisar Comboio";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 341);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdmin";
            this.Text = "Administração";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoClienteToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonApagarRevisor;
        private System.Windows.Forms.TextBox textBoxRevisorSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRevisorTel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxRevisorEmail;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxRevisorCC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxRevisorApelido;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxRevisorNome;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxSearchRevisorCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchRevisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRevisores;
        private System.Windows.Forms.TextBox textBoxSearchRevisorNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCombCapacidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCombCarruagens;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCombTipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCombFabricante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCombID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxSearchCombTipo;
        private System.Windows.Forms.TextBox textBoxSearchCombID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBoxComboios;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSearchCombFabricante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem revisorToolStripMenuItem;
        private System.Windows.Forms.Button buttonSearchComboio;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBoxSearchRevisorMin;
        private System.Windows.Forms.TextBox textBoxSearchRevisorMax;
    }
}