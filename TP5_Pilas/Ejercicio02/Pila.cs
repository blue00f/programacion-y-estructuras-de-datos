using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Pila
    {
        Nodo centinela;
        public Pila()
        {
            centinela = new Nodo();
        }

        public void Apilar(string pNombre)
        {
            Nodo aux = new Nodo(pNombre);
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                aux.Siguiente = centinela.Siguiente;
                centinela.Siguiente = aux;
            }
        }

        public Nodo Desapilar()
        {
            Nodo aux = centinela.Siguiente;
            if (aux != null)
            {
                centinela.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
            return aux;
        }

        public Nodo Ver()
        {
            Nodo aux = null;
            if (centinela.Siguiente != null)
            {
                aux = new Nodo(centinela.Siguiente.Nombre);
            }
            return aux;
        }
    }
}
