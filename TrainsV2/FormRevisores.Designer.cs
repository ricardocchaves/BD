namespace TrainsV2
{
    partial class FormRevisores
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxSearchValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.listBoxRevisores = new System.Windows.Forms.ListBox();
            this.textBoxSearchPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoRevisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.textBoxRevisorSalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonApagarRevisor = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(12, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(760, 251);
            this.panel7.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Controls.Add(this.textBox1);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.button3);
            this.panel8.Controls.Add(this.textBoxSearchValor);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.button9);
            this.panel8.Controls.Add(this.listBoxRevisores);
            this.panel8.Controls.Add(this.textBoxSearchPartida);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(349, 240);
            this.panel8.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MAIOR QUE",
            "MENOR QUE",
            "IGUAL A"});
            this.comboBox1.Location = new System.Drawing.Point(68, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxSearchValor
            // 
            this.textBoxSearchValor.Location = new System.Drawing.Point(152, 89);
            this.textBoxSearchValor.Name = "textBoxSearchValor";
            this.textBoxSearchValor.Size = new System.Drawing.Size(112, 20);
            this.textBoxSearchValor.TabIndex = 16;
            this.textBoxSearchValor.TextChanged += new System.EventHandler(this.textBoxSearchValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(270, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 14;
            this.button9.Text = "SEARCH";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // listBoxRevisores
            // 
            this.listBoxRevisores.FormattingEnabled = true;
            this.listBoxRevisores.Location = new System.Drawing.Point(7, 116);
            this.listBoxRevisores.Name = "listBoxRevisores";
            this.listBoxRevisores.Size = new System.Drawing.Size(338, 121);
            this.listBoxRevisores.TabIndex = 9;
            // 
            // textBoxSearchPartida
            // 
            this.textBoxSearchPartida.Location = new System.Drawing.Point(68, 24);
            this.textBoxSearchPartida.Name = "textBoxSearchPartida";
            this.textBoxSearchPartida.Size = new System.Drawing.Size(196, 20);
            this.textBoxSearchPartida.TabIndex = 7;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.novoRevisorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.voltarToolStripMenuItem.Text = "< Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // novoRevisorToolStripMenuItem
            // 
            this.novoRevisorToolStripMenuItem.Name = "novoRevisorToolStripMenuItem";
            this.novoRevisorToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.novoRevisorToolStripMenuItem.Text = "Novo Revisor";
            this.novoRevisorToolStripMenuItem.Click += new System.EventHandler(this.novoRevisorToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 20;
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
            // buttonApagarRevisor
            // 
            this.buttonApagarRevisor.Location = new System.Drawing.Point(7, 154);
            this.buttonApagarRevisor.Name = "buttonApagarRevisor";
            this.buttonApagarRevisor.Size = new System.Drawing.Size(121, 66);
            this.buttonApagarRevisor.TabIndex = 18;
            this.buttonApagarRevisor.Text = "ELIMINAR REVISOR";
            this.buttonApagarRevisor.UseVisualStyleBackColor = true;
            // 
            // FormRevisores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 286);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel7);
            this.Name = "FormRevisores";
            this.Text = "Revisores";
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listBoxRevisores;
        private System.Windows.Forms.TextBox textBoxSearchPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoRevisorToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxSearchValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.Button buttonApagarRevisor;
    }
}