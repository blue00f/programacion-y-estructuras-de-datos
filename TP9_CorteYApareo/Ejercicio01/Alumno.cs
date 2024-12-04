using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Alumno
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Alumno(string dni, string nombre, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
        public class DniASC : IComparer<Alumno>
        {
            public int Compare(Alumno? x, Alumno? y)
            {
                int rta = 0;
                if (Convert.ToInt32(x.Dni) < Convert.ToInt32(y.Dni)) rta = -1;
                if (Convert.ToInt32(x.Dni) > Convert.ToInt32(y.Dni)) rta = 1;
                return rta;
            }
        }
        public class DniDESC : IComparer<Alumno>
        {
            public int Compare(Alumno? x, Alumno? y)
            {
                return new Alumno.DniASC().Compare(x, y) * -1;
            }
        }
    }
}
