using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraPila
{
    internal class Pila
    {

        Expediente centinela;
        public Pila() { centinela=new Expediente(DateTime.Parse("1/1/2000")); }
        public void Apilar(DateTime pFecha, string pId)
        {
            Expediente aux = new Expediente(pFecha,pId);
            //Cola sin Expedientes
            if (centinela.Siguiente==null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                //Le indicamos al nuevo Expediente que apunto al que estaba en la cima de la pila
                aux.Siguiente=centinela.Siguiente;
                //Le indicamos al centinela apunte al nuevo Expediente que queda en la cima
                centinela.Siguiente=aux;
            }
        }
        public void ApilarOrdenado(DateTime pFecha, string pId)
        {
            Expediente aux = new Expediente(pFecha, pId);
            //Pila sin Expedientes
            if (centinela.Siguiente==null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                Pila pilaAux = new Pila();
                //Mientras la fecha del nuevo expdiente sea más nueva
                //que la del expediente que se encuantra en la cima de la Pila
                //desapilo de la original y apilo en la auxiliar
               
                while ((centinela.Siguiente!=null && aux.Fecha>centinela.Siguiente.Fecha) || (centinela.Siguiente!=null && aux.Fecha==centinela.Siguiente.Fecha && int.Parse(aux.Id)>int.Parse(centinela.Siguiente.Id)))
                {
                    Expediente exp = Desapilar();
                    pilaAux.Apilar(exp.Fecha, exp.Id);
                }
                
                //Apilo el nuevo nodo en la original
                Apilar(pFecha, pId);
                //Vuelvo a pasar lo de la pila auxiliar a la original
                while (pilaAux.Ver()!=null)

                {
                    Expediente expAux = pilaAux.Desapilar();
                    Apilar(expAux.Fecha, expAux.Id);
                }

                
            }
        }
        public Expediente Desapilar()
        {
            Expediente aux = centinela.Siguiente;
            // Solo si la cola posee Expedientes
            if (aux!=null)
            {
                centinela.Siguiente = aux.Siguiente;
                aux.Siguiente=null;
            }
            return aux;

        }
        public Expediente Ver()
        {
            Expediente aux = null;
            // Solo si la pila posee Expedientes
            if (centinela.Siguiente!=null) aux= new Expediente(centinela.Siguiente.Fecha, centinela.Siguiente.Id);
            return aux;
        }
    }
}
