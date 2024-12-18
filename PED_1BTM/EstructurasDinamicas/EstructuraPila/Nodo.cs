using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraPila
{
    internal class Nodo
    {
        public Nodo(string pId = "") { Id=pId; Siguiente=null; }
        public string Id { get; set; }
        public Nodo Siguiente { get; set; }
    }
}
