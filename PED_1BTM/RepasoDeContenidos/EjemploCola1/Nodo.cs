using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola1
{
    internal class Nodo
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public Nodo? Siguiente { get; set; }
        public Nodo()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Edad = 0;
            Siguiente = null;
        }
        public Nodo(string pNombre, string pApellido, int pEdad) : this()
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Edad = pEdad;
        }
    }
}
