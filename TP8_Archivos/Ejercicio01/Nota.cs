using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Nota
    {
        public string Dni { get; set; }
        public float Calificacion { get; set; }
        public DateTime Fecha { get; set; }
        public Nota(string dni, float calificacion, DateTime fecha)
        {
            Dni = dni;
            Calificacion = calificacion;
            Fecha = fecha;
        }
    }
}
