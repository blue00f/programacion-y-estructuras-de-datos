using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola
{
    internal class Cola
    {
        Nodo centinela;
        public Cola()
        {
            centinela = new Nodo();
        }

        public void Encolar(string nombre, int monto)
        {
            Nodo nodo = new Nodo(nombre, monto);
            if(centinela.Siguiente == null)
            {
                centinela.Siguiente = nodo;
            }
            else
            {
                BuscarUltimo().Siguiente = nodo;
            }
        }

        public Nodo Desencolar()
        {
            Nodo nodoEliminado;
            if(centinela.Siguiente == null)
            {
                nodoEliminado = null;
            }
            else
            {
                nodoEliminado = centinela.Siguiente;
                centinela.Siguiente = nodoEliminado.Siguiente;
                nodoEliminado.Siguiente = null;
            }
            return nodoEliminado;
        }

        public Nodo? Ver()
        {
            Nodo nodo = null;
            if(centinela.Siguiente != null)
            {
                nodo = new Nodo(centinela.Nombre, centinela.Monto);
            }
            return nodo;
        }

        private Nodo BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }
        
        private Nodo BuscarUltimoRecursiva(Nodo? primerNodo)
        {
            Nodo n = primerNodo;
            if(n.Siguiente != null)
            {
                n = BuscarUltimoRecursiva(n.Siguiente);
            }
            return n;
        }
    }
}
