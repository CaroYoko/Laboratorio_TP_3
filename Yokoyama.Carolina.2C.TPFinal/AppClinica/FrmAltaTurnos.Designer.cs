namespace AppClinica
{
    partial class FrmAltaTurnos
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
            this.btnGenerarTurno = new System.Windows.Forms.Button();
            this.dpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.lblDniPaciente = new System.Windows.Forms.Label();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.lblDniMedico = new System.Windows.Forms.Label();
            this.lblFechaTurno = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerarTurno
            // 
            this.btnGenerarTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarTurno.Location = new System.Drawing.Point(104, 306);
            this.btnGenerarTurno.Name = "btnGenerarTurno";
            this.btnGenerarTurno.Size = new System.Drawing.Size(232, 45);
            this.btnGenerarTurno.TabIndex = 4;
            this.btnGenerarTurno.Text = "GENERAR TURNO";
            this.btnGenerarTurno.UseVisualStyleBackColor = true;
            this.btnGenerarTurno.Click += new System.EventHandler(this.btnGenerarTurno_Click);
            // 
            // dpFechaTurno
            // 
            this.dpFechaTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dpFechaTurno.CustomFormat = "dd/MM/yyyy";
            this.dpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFechaTurno.Location = new System.Drawing.Point(151, 194);
            this.dpFechaTurno.Name = "dpFechaTurno";
            this.dpFechaTurno.Size = new System.Drawing.Size(245, 23);
            this.dpFechaTurno.TabIndex = 5;
            // 
            // cbPacientes
            // 
            this.cbPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(151, 38);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(243, 23);
            this.cbPacientes.TabIndex = 7;
            // 
            // lblDniPaciente
            // 
            this.lblDniPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDniPaciente.AutoSize = true;
            this.lblDniPaciente.Location = new System.Drawing.Point(49, 41);
            this.lblDniPaciente.Name = "lblDniPaciente";
            this.lblDniPaciente.Size = new System.Drawing.Size(81, 15);
            this.lblDniPaciente.TabIndex = 8;
            this.lblDniPaciente.Text = "D.N.I Paciente";
            // 
            // cbMedicos
            // 
            this.cbMedicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(151, 142);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(243, 23);
            this.cbMedicos.TabIndex = 9;
            // 
            // lblDniMedico
            // 
            this.lblDniMedico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDniMedico.AutoSize = true;
            this.lblDniMedico.Location = new System.Drawing.Point(54, 145);
            this.lblDniMedico.Name = "lblDniMedico";
            this.lblDniMedico.Size = new System.Drawing.Size(76, 15);
            this.lblDniMedico.TabIndex = 10;
            this.lblDniMedico.Text = "D.N.I Médico";
            // 
            // lblFechaTurno
            // 
            this.lblFechaTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaTurno.AutoSize = true;
            this.lblFechaTurno.Location = new System.Drawing.Point(41, 197);
            this.lblFechaTurno.Name = "lblFechaTurno";
            this.lblFechaTurno.Size = new System.Drawing.Size(89, 15);
            this.lblFechaTurno.TabIndex = 11;
            this.lblFechaTurno.Text = "Fecha del turno";
            // 
            // cbHorario
            // 
            this.cbHorario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(151, 246);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(243, 23);
            this.cbHorario.TabIndex = 12;
            this.cbHorario.Text = "\"Elegir un horario\"";
            this.cbHorario.Click += new System.EventHandler(this.cbHorario_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(14, 249);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(116, 15);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Horarios Disponibles";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(151, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(49, 93);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(72, 15);
            this.lblEspecialidad.TabIndex = 15;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // FrmAltaTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 374);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.lblFechaTurno);
            this.Controls.Add(this.lblDniMedico);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.lblDniPaciente);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.dpFechaTurno);
            this.Controls.Add(this.btnGenerarTurno);
            this.Name = "FrmAltaTurnos";
            this.Text = "Alta Turnos";
            this.Load += new System.EventHandler(this.FrmAltaTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerarTurno;
        private System.Windows.Forms.DateTimePicker dpFechaTurno;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Label lblDniPaciente;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.Label lblDniMedico;
        private System.Windows.Forms.Label lblFechaTurno;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEspecialidad;
    }
}