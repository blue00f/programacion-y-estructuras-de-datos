using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteDeControl1
{
    internal class Vendedor
    {
        public string Nombre { get; set; }
        public int Factura { get; set; }

        public Vendedor(string nombre, int factura)
        {
            Nombre = nombre;
            Factura = factura;
        }

        public class NombreASC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                int rdo = x.Nombre.CompareTo(y.Nombre);
                return rdo;
            }
        }
        public class NombreDESC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                return new Vendedor.NombreASC().Compare(x, y) * -1;
            }
        }
    }
}
