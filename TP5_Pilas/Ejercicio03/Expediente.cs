using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Expediente
    {
        public Expediente Siguiente { get; set; }
        public DateTime Fecha { get; set; }
        public string Id { get; set; }
        public string Caratula { get; set; }

        public Expediente(DateTime pFecha, string pId = "", string pCaratula = "")
        {
            Fecha = pFecha;
            Id = pId;
            Caratula = pCaratula;
            Siguiente = null;
        }
    }
}
