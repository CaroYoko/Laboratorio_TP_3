namespace AppClinica
{
    partial class FrmAltaPacientes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cbObraSocial = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(331, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "NOMBRE";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(51, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(331, 23);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "APELLIDO";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(51, 156);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(331, 23);
            this.txtCelular.TabIndex = 2;
            this.txtCelular.Text = "CELULAR";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(51, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(331, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "EMAIL";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(51, 269);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(331, 23);
            this.txtDni.TabIndex = 4;
            this.txtDni.Text = "DNI";
            // 
            // cbObraSocial
            // 
            this.cbObraSocial.FormattingEnabled = true;
            this.cbObraSocial.Location = new System.Drawing.Point(51, 327);
            this.cbObraSocial.Name = "cbObraSocial";
            this.cbObraSocial.Size = new System.Drawing.Size(331, 23);
            this.cbObraSocial.TabIndex = 5;
            this.cbObraSocial.Text = "OBRA SOCIAL";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(118, 387);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(193, 35);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmAltaPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 460);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbObraSocial);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmAltaPacientes";
            this.Text = "Alta Pacientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cbObraSocial;
        private System.Windows.Forms.Button btnAceptar;
    }
}