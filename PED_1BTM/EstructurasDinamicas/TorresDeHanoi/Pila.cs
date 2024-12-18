using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorresDeHanoi
{
    internal class Pila
    {

        Nodo centinela;
        public Pila() { centinela=new Nodo(); }
        public void Apilar(string pId)
        {
            Nodo aux = new Nodo(pId);
            //Cola sin nodos
            if (centinela.Siguiente==null)
            {
                centinela.Siguiente = aux;
            }
            else
            {
                //Le indicamos al nuevo nodo que apunto al que estaba en la cima de la pila
                aux.Siguiente=centinela.Siguiente;
                //Le indicamos al centinela apunte al nuevo nodo que queda en la cima
                centinela.Siguiente=aux;
            }
        }
        public Nodo Desapilar()
        {
            Nodo aux = centinela.Siguiente;
            // Solo si la cola posee nodos
            if (aux!=null)
            {
                centinela.Siguiente = aux.Siguiente;
                aux.Siguiente=null;
            }
            return aux;
        }
        public Nodo Ver()
        {
            Nodo aux = centinela.Siguiente;
            // Solo si la cola posee nodos
            if (aux!=null) aux= new Nodo(aux.Id);
            return aux;

        }
    }
}
