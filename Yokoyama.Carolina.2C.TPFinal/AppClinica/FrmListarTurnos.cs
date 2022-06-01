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
    public partial class FrmListarTurnos : Form
    {
        public FrmListarTurnos()
        {
            InitializeComponent();
        }
        private void FrmListarTurnos_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }


        private void ActualizarDataGrid()
        {
            dgTurnos.DataSource = Clinica.listadoTurnos;
           // AjustarOrdenColumnas();

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (ObtenerExtension() == ETipoExtension.Json)
            {
                ArchivosJson<List<Turno>>.Escribir(Clinica.listadoTurnos, "Turnos");
            }
            else {
                ArchivosXml<List<Turno>>.Escribir(Clinica.listadoTurnos, "Turnos");
            }
           
            // Clinica.Exportar<List<Turno>>(Clinica.listadoTurnos, "Turnos", ObtenerExtension());
        }


        private ETipoExtension ObtenerExtension()
        {
            if (rbJson.Checked)
            {
                return ETipoExtension.Json;
            }
            else
            {
                return ETipoExtension.Xml;
            }
        }

        /*private void AjustarOrdenColumnas()
        {
            dgTurnos.Columns["Id"].DisplayIndex = 0;
            dgTurnos.Columns["Nombre"].DisplayIndex = 1;
            dgTurnos.Columns["Apellido"].DisplayIndex = 2;
            dgTurnos.Columns["Dni"].DisplayIndex = 3;
            dgTurnos.Columns["ObraSocial"].DisplayIndex = 4;
            dgTurnos.Columns["Celular"].DisplayIndex = 5;
            dgTurnos.Columns["Email"].DisplayIndex = 4;
        }*/
    }
}
