namespace TrainsV2
{
    partial class FormMenu
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
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonRevisores = new System.Windows.Forms.Button();
            this.buttonComboios = new System.Windows.Forms.Button();
            this.buttonHorarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClientes
            // 
            this.buttonClientes.Location = new System.Drawing.Point(12, 12);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Size = new System.Drawing.Size(114, 104);
            this.buttonClientes.TabIndex = 0;
            this.buttonClientes.Text = "CLIENTES";
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonRevisores
            // 
            this.buttonRevisores.Location = new System.Drawing.Point(148, 12);
            this.buttonRevisores.Name = "buttonRevisores";
            this.buttonRevisores.Size = new System.Drawing.Size(114, 104);
            this.buttonRevisores.TabIndex = 1;
            this.buttonRevisores.Text = "REVISORES";
            this.buttonRevisores.UseVisualStyleBackColor = true;
            this.buttonRevisores.Click += new System.EventHandler(this.buttonRevisores_Click);
            // 
            // buttonComboios
            // 
            this.buttonComboios.Location = new System.Drawing.Point(12, 145);
            this.buttonComboios.Name = "buttonComboios";
            this.buttonComboios.Size = new System.Drawing.Size(114, 104);
            this.buttonComboios.TabIndex = 2;
            this.buttonComboios.Text = "COMBOIOS";
            this.buttonComboios.UseVisualStyleBackColor = true;
            this.buttonComboios.Click += new System.EventHandler(this.buttonComboios_Click);
            // 
            // buttonHorarios
            // 
            this.buttonHorarios.Location = new System.Drawing.Point(148, 145);
            this.buttonHorarios.Name = "buttonHorarios";
            this.buttonHorarios.Size = new System.Drawing.Size(114, 104);
            this.buttonHorarios.TabIndex = 3;
            this.buttonHorarios.Text = "HORÁRIOS";
            this.buttonHorarios.UseVisualStyleBackColor = true;
            this.buttonHorarios.Click += new System.EventHandler(this.buttonHorarios_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonHorarios);
            this.Controls.Add(this.buttonComboios);
            this.Controls.Add(this.buttonRevisores);
            this.Controls.Add(this.buttonClientes);
            this.Name = "FormMenu";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonRevisores;
        private System.Windows.Forms.Button buttonComboios;
        private System.Windows.Forms.Button buttonHorarios;
    }
}