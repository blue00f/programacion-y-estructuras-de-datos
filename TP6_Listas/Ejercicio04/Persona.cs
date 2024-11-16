using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Dni { get; set; }
        public Jugador Siguiente { get; set; }
        public Jugador(string nombre, string apellido, int edad, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Dni = dni;
            Siguiente = null;
        }
        public Jugador()
        {
            Nombre = null;
            Apellido = null;
            Edad = 0;
            Dni = null;
            Siguiente = null;
        }

        public Jugador CloneTipado(Jugador pPersona)
        {
            Jugador aux = (Jugador)this.MemberwiseClone();
            aux.Siguiente = null;
            return aux;
        }
    }
}
