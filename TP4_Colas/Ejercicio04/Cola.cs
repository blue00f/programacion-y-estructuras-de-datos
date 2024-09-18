using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Cola
    {
        Cliente centinela;
        public Cola()
        {
            centinela = new Cliente();
        }

        public void Encolar()
        {
            Cliente c = new Cliente();
            Cliente aQuienEncolo;
            if (centinela.Siguiente == null)
            {
                aQuienEncolo = centinela;
            }
            else
            {
                aQuienEncolo = BuscarUltimo();
            }
            aQuienEncolo.Siguiente = c;
        }

        public Cliente Desencolar()
        {
            Cliente aQuienSaco = null;
            if (centinela.Siguiente != null)
            {
                aQuienSaco = centinela.Siguiente;
                centinela.Siguiente = aQuienSaco.Siguiente;
                aQuienSaco.Siguiente = null;
            }
            return aQuienSaco;
        }

        public Cliente Ver()
        {
            Cliente aQuienMuestro = null;
            if (centinela.Siguiente != null)
            {
                aQuienMuestro = new Cliente();
            }
            return aQuienMuestro;
        }

        private Cliente BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }

        private Cliente BuscarUltimoRecursiva(Cliente pCliente)
        {
            Cliente c = pCliente;
            if (c.Siguiente != null)
            {
                c = BuscarUltimoRecursiva(c.Siguiente);
            }
            return c;
        }
    }
}
