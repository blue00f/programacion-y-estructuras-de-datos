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
        Persona centinela;
        public Cola() { centinela=new Persona(); }
        public void Encolar(string pNombre,Persona.Sexo pSexo)
        {
            
            //Creamos el nuevo Persona
            Persona? n = new Persona(pNombre,pSexo);
            //DecNombreimos a que Persona se le debe encolar el nuevo Persona
            ////Persona? aQuienEncolo;
            if(centinela.Siguiente==null) // Si la cola está vacía
            {
                ////aQuienEncolo= centinela;
                centinela.Siguiente = n;
            }
            else // Si la cola posee Personas
            {
                ////aQuienEncolo = BuscarUltimo();
                BuscarUltimo().Siguiente=n;
            }
            // Encolo
            ////aQuienEncolo.Siguiente=n;

            
        }
        public Persona? Desencolar()
        {
            Persona? aQuienSaco=null;
            if (centinela.Siguiente!=null) //Cola con Personas
            {
                aQuienSaco=centinela.Siguiente; // Apuntamos con aQuienSaco el Persona a desencolar
                centinela.Siguiente= aQuienSaco.Siguiente; // Reasignamos el puntero del centinela al nuevo primer Persona (puede ser un Persona o null)
                aQuienSaco.Siguiente=null; // Rompemos la referencia del Persona que desencolo, hacia su siguiente Persona.
            }         
            return aQuienSaco;
        }
        public Persona? Ver()
        {
            Persona? aQuienMuestro = null;
            if (centinela.Siguiente!=null) //Cola con Personas
            {
                aQuienMuestro=new Persona(centinela.Siguiente.Nombre,centinela.Siguiente.SexoPersona); // Creamosun Persona nuevo con el Nombre del Persona a desencolar
            }
            return aQuienMuestro;
        }
        private Persona? BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }

        private Persona? BuscarUltimoRecursiva(Persona? pPersona)
        {
            Persona? n = pPersona;
            if (n.Siguiente!=null)
            {
                n = BuscarUltimoRecursiva(n.Siguiente);
            }
            return n;
        }
    }
}
