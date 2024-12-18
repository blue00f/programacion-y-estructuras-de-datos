using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPila1
{
    internal class Pila
    {
        Nodo centinela;
        public Pila()
        {
            centinela = new Nodo();
        }

        public void Apilar(DateTime pFechaNacimiento, string pNombre)
        {
            Nodo nuevoNodo = new Nodo(pFechaNacimiento, pNombre);
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = centinela.Siguiente;
                centinela.Siguiente = nuevoNodo;
            }
        }

        public Nodo Desapilar()
        {
            Nodo aQuienDesapilo = centinela.Siguiente;
            if (centinela.Siguiente != null)
            {
                centinela.Siguiente = aQuienDesapilo.Siguiente;
                aQuienDesapilo.Siguiente = null;
            }
            return aQuienDesapilo;
        }

        public Nodo Ver()
        {
            Nodo aQuienMuestro = null;
            if (centinela.Siguiente != null)
            {
                aQuienMuestro = new Nodo(centinela.Siguiente.FechaNacimiento, centinela.Siguiente.Nombre);
            }
            return aQuienMuestro;
        }
    }
}
