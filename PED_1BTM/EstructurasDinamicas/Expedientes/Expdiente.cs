using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraPila
{
    internal class Expediente
    {
        public Expediente(DateTime pFecha, string pId = "") { Fecha = pFecha; Id=pId; Siguiente=null; }

        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public Expediente Siguiente { get; set; }
    }
}
