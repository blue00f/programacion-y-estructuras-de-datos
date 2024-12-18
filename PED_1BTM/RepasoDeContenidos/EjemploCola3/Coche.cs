using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola2
{
    internal class Coche
    {
        public string Modelo { get; set; }
        public Motor TipoMotor { get; set; }
        public Coche? Siguiente { get; set; }

        public enum Motor
        {
            Gasolina = 0,
            Diesel = 1,
            Electrico = 2,
            Hibrido = 3,
        }

        public Coche(string modelo, Motor motor)
        {
            Modelo = modelo;
            TipoMotor = motor;
            Siguiente = null;
        }
        public Coche()
        {
            Modelo = "";
            Siguiente = null;
        }
    }
}
