using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Nodo
    {
        public Nodo Siguiente { get; set; }
        public string Id { get; set; }

        public Nodo(string pId = "")
        {
            Id = pId;
            Siguiente = null;
        }
    }
}
