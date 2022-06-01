using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public enum EObraSocial { 

            UNIONPERSONAL, OSDE, PASTEUR, SWISSMEDICAL, GALENO       

        }
       
        EObraSocial obraSocial;
        Random random = new Random();

        public Paciente(string nombre, string apellido, string celular, string email, int dni, EObraSocial obraSocial) : base(nombre, apellido, celular, email, dni)
        {
            this.obraSocial = obraSocial;
        }
       

        public EObraSocial ObraSocial
        {
            get { return this.obraSocial; }
            set { this.obraSocial = value; }        
        }


        public static Paciente BuscarPacientePorDNI(int dniPaciente)
        {            
            foreach (Paciente paciente in Clinica.listadoPacientes)
            {
                if (paciente.Dni == dniPaciente)
                {
                    return paciente;                    
                }
            }

            throw new NoExisteException("Paciente no registrados");           

        }
        public static Paciente BuscarPacientePorId(int idPaciente)
        {
            Paciente auxPaciente = null;
            foreach (Paciente paciente in Clinica.listadoPacientes)
            {
                if (paciente.Dni == idPaciente)
                {
                    auxPaciente = paciente;
                    break;
                }
            }
            return auxPaciente;

        }


        public override void AgregarAListado()
        {
            Clinica.listadoPacientes.Add(this);
        }

       
    }
}
