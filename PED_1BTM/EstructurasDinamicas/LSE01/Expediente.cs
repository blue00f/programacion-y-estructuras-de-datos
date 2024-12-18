using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE01
{
    internal class Expediente
    {
        public Expediente(string pId = "") { Id=pId; }
        public string Id { get; set; }
        public Expediente? Siguiente { get; set; }

       
        public Expediente CloneTipado()
        {
            Expediente auxExpediente = (Expediente)this.MemberwiseClone();
            auxExpediente.Siguiente=null;
            return auxExpediente;
        }
    }
}
