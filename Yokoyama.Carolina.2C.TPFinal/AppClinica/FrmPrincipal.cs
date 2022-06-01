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
    public partial class FrmPrincipal : Form
    {
        static bool primeraCargaPacientes;
        static bool primeraCargaMedicos;
        static bool primeraCargaTurnos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (!primeraCargaPacientes)
            {
                Clinica.Importar<Paciente>("Pacientes.json");
                primeraCargaPacientes = true;
            }

            if (!primeraCargaMedicos)
            {
                Clinica.Importar<Medico>("Medicos.json");
                primeraCargaMedicos = true;
            }
                       
            if (!primeraCargaTurnos)
            {
                Clinica.Importar<Turno>("Turnos.json");
                primeraCargaTurnos = true;
            }

            cbFiltrado.DataSource = Enum.GetValues(typeof(Turno.Estado));

            this.ActualizarDataGrid();
           
        } 
               
        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPacientes frmAltaTurno = new FrmAltaPacientes(); 
            frmAltaTurno.ShowDialog();

        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarPacientes frmListarPacientes = new FrmListarPacientes();
            frmListarPacientes.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarMedicos frmListarMedicos = new FrmListarMedicos();
            frmListarMedicos.ShowDialog();
        }

        public void ActualizarDataGrid()
        {
            dgTurnosHoy.DataSource = Clinica.BuscarTurno(DateTime.Now.Date);

            List<Turno> auxLista = new List<Turno>();

            switch ((Turno.Estado)cbFiltrado.SelectedItem)
            {
                case Turno.Estado.Ausente:
                    auxLista = Turno.FiltrarPorEstado(Turno.Estado.Ausente);
                    break;
                case Turno.Estado.Pendiente:
                    auxLista = Turno.FiltrarPorEstado(Turno.Estado.Pendiente);
                    break;
                case Turno.Estado.Atendido:
                    auxLista = Turno.FiltrarPorEstado(Turno.Estado.Atendido);
                    break;
                case Turno.Estado.Espera:
                    auxLista = Turno.FiltrarPorEstado(Turno.Estado.Espera);
                    break;
                case Turno.Estado.Todos:
                    auxLista = Turno.FiltrarPorEstado(Turno.Estado.Todos);
                    break;
            }

          

            dgTurnosHoy.DataSource = auxLista;                       

            dgTurnosHoy.Refresh();
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaTurnos frmAltaTurnos = new FrmAltaTurnos();  
            frmAltaTurnos.ShowDialog();
        }

        private void verTodosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarTurnos frmListarTurnos = new FrmListarTurnos();
            frmListarTurnos.ShowDialog();

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEstado frmIngresarEstado = new FrmIngresarEstado();
            this.Visible = false;
            frmIngresarEstado.ShowDialog();
            this.Visible = true;
            this.ActualizarDataGrid();
        }

        private void atenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencion frmAtenderPaciente  = new FrmAtencion();
            this.Visible = false;
            frmAtenderPaciente.ShowDialog();
            this.Visible = true;
            this.ActualizarDataGrid();
        }

        private void cbFiltrado_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ActualizarDataGrid();
        }


        /*
        private DataGridViewComboBoxColumn CrearComboBoxDeEstado()
        {
            DataGridViewComboBoxColumn comboboxPresentes = new DataGridViewComboBoxColumn();
            comboboxPresentes.ValueType = typeof(Turno.Estado);
            comboboxPresentes.DataSource = Enum.GetValues(typeof(Turno.Estado));
            comboboxPresentes.DataPropertyName = "Estado";
            comboboxPresentes.Name = "Estado";
            return comboboxPresentes;
        }
        */
    }
}
