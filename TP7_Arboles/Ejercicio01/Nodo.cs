using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Nodo
    {
        public string texto {  get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }

        public Nodo()
        {
            Izq = null;
            Der = null;
        }
        public Nodo(string pTexto) : this()
        {
            texto = pTexto;
        }
    }
}
