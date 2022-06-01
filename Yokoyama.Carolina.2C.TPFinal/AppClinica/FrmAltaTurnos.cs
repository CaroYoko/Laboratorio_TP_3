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
    public partial class FrmAltaTurnos : Form
    {
        List<string> horarios = new List<string>() { "9:00", "9:15", "9:30", "9:45", "10:00", "10:15", "10:30", "10:45", "11:00", "11:15", "11:30", "11:45", "12:00", "12:15", "12:30", "12:45", "13:00", "13:15", "13:30", "13:45", "14:00", "14:15", "14:30", "14:45", "15:00" };

        public FrmAltaTurnos()
        {
            InitializeComponent();
        }

        private void FrmAltaTurnos_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection stringColPaciente = new AutoCompleteStringCollection();
            foreach (Paciente paciente in Clinica.listadoPacientes)
            {
                stringColPaciente.Add(paciente.Dni.ToString());
            }
            cbPacientes.AutoCompleteCustomSource = stringColPaciente;
            cbPacientes.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbPacientes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;


            AutoCompleteStringCollection stringColMedico = new AutoCompleteStringCollection();
            foreach (Medico medico in Clinica.listadoMedico)
            {
                stringColMedico.Add(medico.Dni.ToString());
            }
            cbMedicos.AutoCompleteCustomSource = stringColMedico;
            cbMedicos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbMedicos.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cbHorario.DataSource = horarios;
            cbHorario.SelectedIndex = -1;

        }


        private List<string> CalcularHorarioDisponible()
        {

            List<string> horaMinutosParaMedicosFecha = new List<string>();
            List<string> horarioDisponible = new List<string>();

            if (Clinica.listadoTurnos.Count != 0)
            {
                foreach (Turno turno in Clinica.listadoTurnos)
                {
                    if (!String.IsNullOrEmpty(cbMedicos.Text) && turno.Medico.Dni == int.Parse(cbMedicos.Text)
                        && turno.FechaYHora.Date == dpFechaTurno.Value.Date)
                    {
                        string horaMinutos = turno.FechaYHora.Hour + ":" + turno.FechaYHora.Minute.ToString().PadLeft(2, '0');
                        horaMinutosParaMedicosFecha.Add(horaMinutos);
                    }
                }

                foreach (string hora in horarios)
                {
                    if (!horaMinutosParaMedicosFecha.Contains(hora))
                    {
                        horarioDisponible.Add(hora);
                    }
                }
            }
            else
            {
                horarioDisponible = horarios;
            }

            return horarioDisponible;

        }


        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = Medico.BuscarMedicoPorDNI(int.Parse(cbMedicos.Text));
                Paciente paciente = Paciente.BuscarPacientePorDNI(int.Parse(cbPacientes.Text));

                DateTime fecha = Convert.ToDateTime(dpFechaTurno.Text);
                DateTime hora = Convert.ToDateTime(cbHorario.SelectedItem);
                DateTime fechaConvertida = fecha.AddHours(hora.Hour).AddMinutes(hora.Minute);

                Turno turno = new Turno(fechaConvertida, paciente, medico);
                turno.AgregarAListado();                
               
                if (MessageBox.Show("Agregado con éxito", "Turno", MessageBoxButtons.OK) == DialogResult.OK) {
                    this.Close();
                }
            }
            catch (NoDisponibleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NoExisteException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception) {
                                
                MessageBox.Show("Los valores ingresados NO son válidos");
            }

        }


        private void cbHorario_Click(object sender, EventArgs e)
        {
            cbHorario.DataSource = CalcularHorarioDisponible();
        }


    }
}
