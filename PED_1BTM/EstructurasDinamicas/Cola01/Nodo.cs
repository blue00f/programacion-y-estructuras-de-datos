using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Cola01
{
    internal class Nodo
    { 
        public Nodo()
        { Siguiente = null; Id=""; }
        public Nodo(string? pId) : this()
        {
            Id=pId;
        }
        public string? Id { get; set; }
        public Nodo? Siguiente { get; set; }

    }
}
