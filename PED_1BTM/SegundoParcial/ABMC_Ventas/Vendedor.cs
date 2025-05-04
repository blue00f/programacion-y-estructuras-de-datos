using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Ventas
{
    internal class Vendedor : IComparer<Vendedor>
    {
        public string Codigo { get; set; }
        public decimal Venta { get; set; }

        public Vendedor(string codigo, decimal venta)
        {
            Codigo = codigo;
            Venta = venta;
        }
        
        public int Compare(Vendedor? x, Vendedor? y)
        {
            int res=0;
            if(string.Compare(x.Codigo, y.Codigo) > 0)
            {
                res = -1;
            }
            return res;
        }
    }
}
