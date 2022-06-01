namespace AppClinica
{
    partial class FrmIngresarEstado
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarTurno = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(189, 41);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(197, 23);
            this.txtDni.TabIndex = 0;
            // 
            // dgPacientes
            // 
            this.dgPacientes.AllowUserToOrderColumns = true;
            this.dgPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Location = new System.Drawing.Point(34, 91);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.RowTemplate.Height = 25;
            this.dgPacientes.Size = new System.Drawing.Size(600, 220);
            this.dgPacientes.TabIndex = 1;
            this.dgPacientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacientes_CellValueChanged);
            // 
            // btnRegistrarTurno
            // 
            this.btnRegistrarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarTurno.Location = new System.Drawing.Point(471, 335);
            this.btnRegistrarTurno.Name = "btnRegistrarTurno";
            this.btnRegistrarTurno.Size = new System.Drawing.Size(163, 26);
            this.btnRegistrarTurno.TabIndex = 2;
            this.btnRegistrarTurno.Text = "Registrar Turno";
            this.btnRegistrarTurno.UseVisualStyleBackColor = true;
            this.btnRegistrarTurno.Click += new System.EventHandler(this.btnRegistrarTurno_Click);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(34, 44);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(140, 15);
            this.lblBuscador.TabIndex = 3;
            this.lblBuscador.Text = "Buscar paciente por D.N.I";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(413, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmIngresarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 389);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.btnRegistrarTurno);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.txtDni);
            this.Name = "FrmIngresarEstado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Estado del Turno";
            this.Load += new System.EventHandler(this.FrmIngresarEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Button btnRegistrarTurno;
        protected System.Windows.Forms.DataGridView dgPacientes;
    }
}