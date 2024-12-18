using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosABM1
{
    internal class Vendedor
    {
        public string Legajo { get; set; }
        public decimal Venta { get; set; }

        public Vendedor(string legajo, decimal venta)
        {
            Legajo = legajo;
            Venta = venta;
        }
    }
}
