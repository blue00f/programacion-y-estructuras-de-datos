using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Nodo
    {
        public string Nombre { get; set; }
        public int Monto { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(string nombre, int monto)
        {
            Nombre = nombre;
            Monto = monto;
            Siguiente = null;
        }
        public Nodo()
        {
            Nombre = "";
            Monto = 0;
            Siguiente = null;
        }
    }
}
