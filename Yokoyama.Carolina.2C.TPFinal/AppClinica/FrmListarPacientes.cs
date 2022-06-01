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
    public partial class FrmListarPacientes : Form
    {
        static Paciente? pacienteSeleccion;
       
        public FrmListarPacientes()
        {
            InitializeComponent();           
        }

        private void FrmListarPacientes_Load(object sender, EventArgs e)
        {
          
            this.ActualizarDataGrid();
            this.ObtenerFila();

        }

        private void ActualizarDataGrid()
        {            
            dgPacientes.DataSource = Clinica.listadoPacientes;
            AjustarOrdenColumnas();

        }

        private void AjustarOrdenColumnas()
        {
            dgPacientes.Columns["Id"].DisplayIndex = 0;
            dgPacientes.Columns["Nombre"].DisplayIndex = 1;
            dgPacientes.Columns["Apellido"].DisplayIndex = 2;
            dgPacientes.Columns["Dni"].DisplayIndex = 3;
            dgPacientes.Columns["ObraSocial"].DisplayIndex = 4;
            dgPacientes.Columns["Celular"].DisplayIndex = 5;
            dgPacientes.Columns["Email"].DisplayIndex = 4;
        }


        private void ObtenerFila()
        {
            int indiceFila = dgPacientes.CurrentRow is not null ? dgPacientes.CurrentRow.Index : -1;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgPacientes.Rows[indiceFila];

                int auxId = int.Parse(fila.Cells["Id"].Value.ToString() ?? "");
               
                FrmListarPacientes.pacienteSeleccion = Paciente.BuscarPacientePorId(auxId);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ArchivosJson<List<Paciente>>.Escribir(Clinica.listadoPacientes, "Pacientes_Exportado");
        }

      
    }
}
