using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Cliente
    {
        public Cliente Siguiente { get; set; }

        public Cliente()
        {
            Siguiente = null;
        }
    }
}
