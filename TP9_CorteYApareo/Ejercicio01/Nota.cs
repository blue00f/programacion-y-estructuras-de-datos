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

        public class DniASC : IComparer<Nota>
        {
            public int Compare(Nota? x, Nota? y)
            {
                int rta = 0;
                if (Convert.ToInt32(x.Dni) < Convert.ToInt32(y.Dni)) rta = -1;
                if (Convert.ToInt32(x.Dni) > Convert.ToInt32(y.Dni)) rta = 1;
                return rta;
            }
        }
        public class DniDESC : IComparer<Nota>
        {
            public int Compare(Nota? x, Nota? y)
            {
                return new Nota.DniASC().Compare(x, y) * -1;
            }
        }
    }
}
