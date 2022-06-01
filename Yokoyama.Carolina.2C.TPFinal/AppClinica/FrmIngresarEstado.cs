using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClinica
{
    public partial class FrmIngresarEstado : Form
    {
        static Turno? turnoSeleccion;
        static Turno.Estado estado;
        public FrmIngresarEstado()
        {
            InitializeComponent();
            FrmIngresarEstado.turnoSeleccion = null;
        }

        public static Turno? ClienteSeleccion
        {
            get { return FrmIngresarEstado.turnoSeleccion; }
        }

        private void FrmIngresarEstado_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection listaAutocompletar = new AutoCompleteStringCollection();

            foreach (Turno turno in Clinica.BuscarTurno(DateTime.Now.Date))
            {
                listaAutocompletar.Add(turno.Paciente.Dni.ToString());
            }

            // configura el textBox del DNI del cliente
            this.txtDni.AutoCompleteCustomSource = listaAutocompletar;
            this.txtDni.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txtDni.AutoCompleteSource = AutoCompleteSource.CustomSource;

            ActualizarDataGrid();

        }

        private void ActualizarDataGrid()
        {
            dgPacientes.DataSource = Clinica.BuscarTurno(DateTime.Now.Date);
            dgPacientes.Columns.Add(CrearComboBoxDeEstado());
            dgPacientes.Columns["EstadoTurno"].Visible = false;
            // AjustarOrdenColumnas();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int dni;

            if (int.TryParse(txtDni.Text, out dni))
            {
                dgPacientes.DataSource = Clinica.BuscarTurno(DateTime.Now.Date, dni);
            }
            else
            {
                MessageBox.Show("El DNI ingresado es invalido");
            }


        }

        private DataGridViewComboBoxColumn CrearComboBoxDeEstado()
        {
            DataGridViewComboBoxColumn comboboxPresentes = new DataGridViewComboBoxColumn();
            comboboxPresentes.ValueType = typeof(Turno.Estado);
            comboboxPresentes.DataSource = new Enum[] { Entidades.Turno.Estado.Espera, Entidades.Turno.Estado.Ausente };
            comboboxPresentes.DataPropertyName = "Estado";
            comboboxPresentes.Name = "Estado";
            return comboboxPresentes;
        }

        private void CargarTurnoSeleccion()
        {
            int indiceFila = dgPacientes.CurrentRow is not null ? dgPacientes.CurrentRow.Index : -1;

            if (indiceFila >= 0)
            {
                DataGridViewRow fila = dgPacientes.Rows[indiceFila];

                int auxId = int.Parse(fila.Cells["IdTurno"].Value.ToString() ?? "");

                foreach (Turno turno in Clinica.BuscarTurno(DateTime.Now.Date))
                {
                    if (turno.IdTurno == auxId)
                    {
                        FrmIngresarEstado.turnoSeleccion = turno;
                    }

                }
            }

        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            CargarTurnoSeleccion();
            if (turnoSeleccion is not null)
            {
                turnoSeleccion.EstadoTurno = estado;
            }

        }

        private void dgPacientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPacientes.Columns[e.ColumnIndex].Name == "Estado")
            {
                DataGridViewComboBoxCell combo = (DataGridViewComboBoxCell)dgPacientes.Rows[e.RowIndex].Cells[e.ColumnIndex];
                FrmIngresarEstado.estado = (Turno.Estado)combo.Value;

            }
        }


      
    }
}
