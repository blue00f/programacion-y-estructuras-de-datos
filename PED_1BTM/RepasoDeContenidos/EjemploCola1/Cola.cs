using EjemploCola1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola1
{
    internal class Cola
    {
        Nodo centinela;
        public Cola()
        {
            centinela = new Nodo();
        }

        public void Encolar(string pNombre, string pApellido, int pEdad)
        {
            Nodo nuevoNodo = new Nodo(pNombre, pApellido, pEdad);
            Nodo aQuienEncolo;
            if (centinela.Siguiente == null)
            {
                aQuienEncolo = centinela;
            }
            else
            {
                aQuienEncolo = BuscarUltimo();
            }
            aQuienEncolo.Siguiente = nuevoNodo;
        }
        public Nodo? Desencolar()
        {
            Nodo? aQuienSaco = null;
            if (centinela.Siguiente != null)
            {
                aQuienSaco = centinela.Siguiente;
                centinela.Siguiente = aQuienSaco.Siguiente;
                aQuienSaco.Siguiente = null;
            }
            return aQuienSaco;
        }
        public Nodo? Ver()
        {
            Nodo? aQuienMuestro = null;
            if (centinela.Siguiente != null)
            {
                aQuienMuestro = new Nodo(centinela.Siguiente.Nombre, centinela.Siguiente.Apellido, centinela.Siguiente.Edad);
            }
            return aQuienMuestro;
        }
        private Nodo BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }
        private Nodo BuscarUltimoRecursiva(Nodo pNodo)
        {
            Nodo n = pNodo;
            if (n.Siguiente != null)
            {
                n = BuscarUltimoRecursiva(n.Siguiente);
            }
            return n;
        }
    }
}
