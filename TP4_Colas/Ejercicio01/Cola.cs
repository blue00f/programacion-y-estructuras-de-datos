using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Cola
    {
        Persona centinela;
        public Cola() { centinela = new Persona(); }
        public void Encolar(string pId, Persona.Sexo pSexo)
        {
            //Creamos el nuevo nodo
            Persona? n = new Persona(pId, pSexo);

            //Decidimos a que nodo se le debe encolar el nuevo nodo
            Persona? aQuienEncolo;
            if (centinela.Siguiente == null) // Si la cola está vacía
            {
                aQuienEncolo = centinela;
            }
            else // Si la cola posee nodos
            {
                aQuienEncolo = BuscarUltimo();
            }
            // Encolo
            aQuienEncolo.Siguiente = n;


        }
        public Persona? Desencolar()
        {
            Persona? aQuienSaco = null;
            if (centinela.Siguiente != null) //Cola con Nodos
            {
                aQuienSaco = centinela.Siguiente; // Apuntamos con aQuienSaco el nodo a desencolar
                centinela.Siguiente = aQuienSaco.Siguiente; // Reasignamos el puntero del centinela al nuevo primer nodo (puede ser un nodo o null)
                aQuienSaco.Siguiente = null; // Rompemos la referencia del nodo que desencolo, hacia su siguiente nodo.
            }
            return aQuienSaco;
        }
        public Persona? Ver()
        {
            Persona? aQuienMuestro = null;
            if (centinela.Siguiente != null) //Cola con Nodos
            {
                aQuienMuestro = new Persona(centinela.Siguiente.Nombre, centinela.Siguiente.SexoPersona); // Creamosun nodo nuevo con el id del nodo a desencolar
            }
            return aQuienMuestro;
        }
        private Persona? BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }

        private Persona? BuscarUltimoRecursiva(Persona? pNodo)
        {
            Persona? n = pNodo;
            if (n.Siguiente != null)
            {
                n = BuscarUltimoRecursiva(n.Siguiente);
            }
            return n;
        }
    }
}
