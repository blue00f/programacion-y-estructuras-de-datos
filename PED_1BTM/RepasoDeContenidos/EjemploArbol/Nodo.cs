using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArbol
{
    internal class Nodo
    {
        public string Nombre { get; set; }
        public Nodo? Izq { get; set; }
        public Nodo? Der { get; set; }

        public Nodo(string nombre)
        {
            Nombre = nombre;
            Izq = null;
            Der = null;
        }
    }
}
