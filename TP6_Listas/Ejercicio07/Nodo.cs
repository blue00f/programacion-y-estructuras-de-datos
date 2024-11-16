using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Nodo
    {
        // El atributo ID va a ser autoincremental
        private static int idContador = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public Nodo? Siguiente { get; set; }

        public Nodo(string nombre)
        {
            Id = idContador++;
            Nombre = nombre;
            Siguiente = null;
        }

        public Nodo()
        {
            Id = 0;
            Nombre = "";
            Siguiente = null;
        }

        public Nodo CloneTipado()
        {
            Nodo auxPaciente = (Nodo)this.MemberwiseClone();
            auxPaciente.Siguiente = null;
            return auxPaciente;
        }
    }
}
