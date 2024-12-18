using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteDeControl3
{
    internal class Vendedor
    {
        public string Nombre { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public int Factura { get; set; }
        public Vendedor(string nombre, string producto, int cantidad, int factura)
        {
            Nombre = nombre;
            Producto = producto;
            Cantidad = cantidad;
            Factura = factura;
        }

        public class VendedorProductoASC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                int rdo = x.Nombre.CompareTo(y.Nombre);
                if (rdo == 0)
                {
                    // Para que el producto se ordene de forma descendente, intercambiamos 'x' por 'y'
                    rdo = y.Producto.CompareTo(x.Producto);
                }
                return rdo;
            }
        }
        public class VendedorProductoDESC : IComparer<Vendedor>
        {
            public int Compare(Vendedor x, Vendedor y)
            {
                return new Vendedor.VendedorProductoASC().Compare(x, y) * -1;
            }
        }
    }
}
