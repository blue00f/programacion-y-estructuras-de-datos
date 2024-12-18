using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola01
{
    internal class Cola
    {
        Nodo centinela;
        public Cola() { centinela=new Nodo(); }
        public void Encolar(string pId)
        {
            
            //Creamos el nuevo nodo
            Nodo? n = new Nodo(pId);
            //Decidimos a que nodo se le debe encolar el nuevo nodo
            Nodo? aQuienEncolo;
            if(centinela.Siguiente==null) // Si la cola está vacía
            {
                aQuienEncolo= centinela;
            }
            else // Si la cola posee nodos
            {
                aQuienEncolo = BuscarUltimo();
            }
            // Encolo
            aQuienEncolo.Siguiente=n;

            
        }
        public Nodo? Desencolar()
        {
            Nodo? aQuienSaco=null;
            if (centinela.Siguiente!=null) //Cola con Nodos
            {
                aQuienSaco=centinela.Siguiente; // Apuntamos con aQuienSaco el nodo a desencolar
                centinela.Siguiente= aQuienSaco.Siguiente; // Reasignamos el puntero del centinela al nuevo primer nodo (puede ser un nodo o null)
                aQuienSaco.Siguiente=null; // Rompemos la referencia del nodo que desencolo, hacia su siguiente nodo.
            }         
            return aQuienSaco;
        }
        public Nodo? Ver()
        {
            Nodo? aQuienMuestro = null;
            if (centinela.Siguiente!=null) //Cola con Nodos
            {
                aQuienMuestro=new Nodo(centinela.Siguiente.Id); // Creamosun nodo nuevo con el id del nodo a desencolar
            }
            return aQuienMuestro;
        }
        private Nodo? BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }

        private Nodo? BuscarUltimoRecursiva(Nodo? pNodo)
        {
            Nodo? n = pNodo;
            if (n.Siguiente!=null)
            {
                n = BuscarUltimoRecursiva(n.Siguiente);
            }
            return n;
        }
    }
}
