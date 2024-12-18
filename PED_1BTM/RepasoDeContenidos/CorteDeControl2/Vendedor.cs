using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteDeControl2
{
    internal class Vendedor
    {
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public int Factura { get; set; }

        public Vendedor(string nombre, string producto, int factura)
        {
            Nombre = nombre;
            Producto = producto;
            Factura = factura;
        }

        public class NombreProductoASC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                int rdo = x.Nombre.CompareTo(y.Nombre);
                if (rdo == 0)
                {
                    rdo = x.Producto.CompareTo(y.Producto);
                }
                return rdo;
            }
        }
        public class NombreProductoDESC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                return new Vendedor.NombreProductoASC().Compare(x, y) * -1;
            }
        }
    }
}
