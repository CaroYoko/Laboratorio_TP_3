using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AppClinica
{
    public partial class FrmAltaPacientes : Form
    {
        public FrmAltaPacientes()
        {
            InitializeComponent();
            cbObraSocial.DataSource = Enum.GetValues(typeof(Paciente.EObraSocial));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int auxDni;

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text) && !string.IsNullOrWhiteSpace(txtCelular.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text) && !string.IsNullOrWhiteSpace(txtDni.Text) && int.TryParse(txtDni.Text,out auxDni))
            {

                Paciente paciente = new Paciente(txtNombre.Text, txtApellido.Text, txtCelular.Text, txtEmail.Text, auxDni, (Paciente.EObraSocial)cbObraSocial.SelectedItem);
                paciente.AgregarAListado();
            }
            else {

                MessageBox.Show("Faltan campos por rellenar o son valores inválidos");
            }

            this.Close();
        }


    }
}
