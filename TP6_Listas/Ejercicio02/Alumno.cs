using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio02
{
    internal class Alumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Alumno? Siguiente { get; set; }

        public Alumno(string nombre, string apellido, string dni, DateTime fechaNacimiento, string direccion, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            Telefono = telefono;
            Siguiente = null;
        }

        public Alumno()
        {
            Nombre = null;
            Apellido = null;
            DNI = null;
            FechaNacimiento = DateTime.MinValue;
            Direccion = null;
            Telefono = null;
            Siguiente = null;
        }

        public Alumno CloneTipado()
        {
            Alumno auxAlumno = (Alumno)this.MemberwiseClone();
            auxAlumno.Siguiente = null;
            return auxAlumno;
        }
    }
}
