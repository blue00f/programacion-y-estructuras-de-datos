using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchivosABM
{
    internal class Herramienta
    {
        public string Nombre { get; set; }
        public TipoHerramienta Tipo { get; set; }
        public int Stock { get; set; }
        public int IdVendedor { get; set; }

        public enum TipoHerramienta
        {
            Pesada = 0,
            Electrica = 1,
            Mano = 2
        }

        public Herramienta (string nombre, Herramienta.TipoHerramienta tipo, int stock, int idVendedor)
        {
            Nombre = nombre;
            Tipo = tipo;
            Stock = stock;
            IdVendedor = idVendedor;
        }
    }
}
