using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona : IListable
    {
        static int ultimoId;
        int id;
        string nombre;
        string apellido;
        string celular;
        string email;
        int dni;

        static Persona() {
            Persona.ultimoId = 1;
        }

        public Persona(string nombre, string apellido, string celular, string email, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.celular = celular;
            this.email = email;
            this.dni = dni;
            this.id = Persona.ultimoId;
            Persona.ultimoId++;
        }

        public int Id
        {
            get { return this.id; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Celular
        {
            get { return this.celular; }
            set { this.celular = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public abstract void AgregarAListado();

        public virtual string MostrarTodo()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y Apellido: {this.nombre} {this.apellido}");
            sb.AppendLine($"D.N.I: {this.dni}"); 
            sb.AppendLine($"Cel: {this.celular}");
            sb.AppendLine($"Email: {this.email}");

            return sb.ToString();

        }

        public override string ToString()
        {
            return string.Format("{0} {1} ",this.Nombre, this.Apellido);
        }


    }
}
