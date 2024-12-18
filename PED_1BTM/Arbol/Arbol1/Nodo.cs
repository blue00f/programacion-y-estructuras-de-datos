using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol1
{
    public class Nodo
    {
        public Nodo() { Izq = null; Der = null; }
        public Nodo(string pTexto) : this()
        { texto = pTexto; }
        public string texto { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }
    }
}
