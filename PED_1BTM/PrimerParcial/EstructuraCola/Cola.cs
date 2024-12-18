using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCola
{
    internal class Cola
    {
        Nodo centinela;
        public Cola() { centinela = new Nodo(); }
        public void Encolar(string pId)
        {
            Nodo aux = new Nodo(pId);
            //Cola sin nodos
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                BuscarUltimo().Siguiente = aux;
            }
        }
        public Nodo Desencolar()
        {
            Nodo aux = centinela.Siguiente;
            // Solo si la cola posee nodos
            if (aux != null)
            {
                centinela.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
            return aux;
        }
        public Nodo Ver()
        {
            Nodo aux = centinela.Siguiente;
            // Solo si la cola posee nodos
            if (aux != null) aux = new Nodo(aux.Id);
            return aux;

        }
        private Nodo BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }
        private Nodo BuscarUltimoRecursiva(Nodo pNodo)
        {
            Nodo aux = pNodo;
            if (aux.Siguiente != null) { aux = BuscarUltimoRecursiva(aux.Siguiente); }
            return aux;
        }
    }
}
