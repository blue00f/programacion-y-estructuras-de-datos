using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Pila
    {
        Expediente centinela;
        public Pila()
        {
            centinela = new Expediente(DateTime.Parse("1/1/2000"));
        }

        public void Apilar(DateTime pFecha, string pId, string pCaratula)
        {
            Expediente aux = new Expediente(pFecha, pId, pCaratula);
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

        public void ApilarOrdenado(DateTime pFecha, string pId, string pCaratula)
        {
            Expediente aux = new Expediente(pFecha, pId, pCaratula);
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                Pila pilaAux = new Pila();

                /*
                 * Mientras la fecha del nuevo expediente sea nueva que la del expediente
                 * que se encuentra en la cima de la Pila, desapilo de la original y apilo en la auxiliar
                */
                while ((centinela.Siguiente != null && aux.Fecha > centinela.Siguiente.Fecha) || (centinela.Siguiente != null && aux.Fecha == centinela.Siguiente.Fecha && int.Parse(aux.Id) > int.Parse(centinela.Siguiente.Id)))
                {
                    Expediente exp = Desapilar();
                    pilaAux.Apilar(exp.Fecha, exp.Id, exp.Caratula);
                }

                //Apilo el nuevo nodo en la original
                Apilar(pFecha, pId, pCaratula);

                //Vuelvo a pasar lo de la pila auxiliar a la original
                while (pilaAux.Ver() != null)
                {
                    Expediente expAux = pilaAux.Desapilar();
                    Apilar(expAux.Fecha, expAux.Id, expAux.Caratula);
                }
            }
        }

        public Expediente Desapilar()
        {
            Expediente aux = centinela.Siguiente;
            if (aux != null)
            {
                centinela.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
            return aux;
        }

        public Expediente Ver()
        {
            Expediente aux = null;
            if (centinela.Siguiente != null)
            {
                aux = new Expediente(centinela.Siguiente.Fecha, centinela.Siguiente.Id, centinela.Siguiente.Caratula);
            }
            return aux;
        }
    }
}
