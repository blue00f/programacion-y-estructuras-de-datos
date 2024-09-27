using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Nodo
    {
        public Nodo Siguiente { get; set; }
        public string Nombre { get; set; }

        public Nodo(string pNombre = "")
        {
            Nombre = pNombre;
            Siguiente = null;
        }
    }
}
