namespace TrainsV2
{
    partial class FormNovoRevisor
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
            this.boxCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxApelido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxSalario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxCC
            // 
            this.boxCC.Location = new System.Drawing.Point(162, 70);
            this.boxCC.Name = "boxCC";
            this.boxCC.Size = new System.Drawing.Size(117, 20);
            this.boxCC.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "CC";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxGenero.Location = new System.Drawing.Point(60, 69);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(56, 21);
            this.comboBoxGenero.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Genero";
            // 
            // boxApelido
            // 
            this.boxApelido.Location = new System.Drawing.Point(89, 39);
            this.boxApelido.Name = "boxApelido";
            this.boxApelido.Size = new System.Drawing.Size(190, 20);
            this.boxApelido.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Apelido";
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(89, 9);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(190, 20);
            this.boxNome.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 9);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Nome próprio";
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(89, 102);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(190, 20);
            this.boxEmail.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            // 
            // boxTelefone
            // 
            this.boxTelefone.Location = new System.Drawing.Point(90, 138);
            this.boxTelefone.Name = "boxTelefone";
            this.boxTelefone.Size = new System.Drawing.Size(190, 20);
            this.boxTelefone.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefone";
            // 
            // boxSalario
            // 
            this.boxSalario.Location = new System.Drawing.Point(90, 173);
            this.boxSalario.Name = "boxSalario";
            this.boxSalario.Size = new System.Drawing.Size(190, 20);
            this.boxSalario.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Salário";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 29;
            this.button1.Text = "ADICIONAR REVISOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addRevisor);
            // 
            // FormNovoRevisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 287);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.boxSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.boxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxApelido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label26);
            this.Name = "FormNovoRevisor";
            this.Text = "Novo Revisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxSalario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}