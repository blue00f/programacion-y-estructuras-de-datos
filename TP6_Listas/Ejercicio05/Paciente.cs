using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Paciente? Anterior { get; set; }
        public Paciente? Siguiente { get; set; }

        public Paciente(int id, string nombre, string apellido, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Anterior = null;
            Siguiente = null;
        }

        public Paciente()
        {
            Id = 0;
            Nombre = null;
            Apellido = null;
            Direccion = null;
            Telefono = null;
            Anterior = null;
            Siguiente = null;
        }

        public Paciente CloneTipado()
        {
            Paciente auxPaciente = (Paciente)this.MemberwiseClone();
            auxPaciente.Siguiente = null;
            return auxPaciente;
        }
    }
}
