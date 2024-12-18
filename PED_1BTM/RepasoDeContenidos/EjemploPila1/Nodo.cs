using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila1
{
    internal class Nodo
    {
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo()
        {
            FechaNacimiento = DateTime.MinValue;
            Nombre = string.Empty;
        }
        public Nodo(DateTime pFechaNacimiento, string pNombre) : this()
        {
            FechaNacimiento = pFechaNacimiento;
            Nombre = pNombre;
        }
    }
}
