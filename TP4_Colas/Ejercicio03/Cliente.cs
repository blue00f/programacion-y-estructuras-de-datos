using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Cliente
    {
        public enum Ticket
        {
            Tiene = 0,
            NoTiene = 1,
        }

        public Cliente()
        { Siguiente = null; Nombre = ""; }
        public Cliente(string? pNombre, Ticket pTicket) : this()
        {
            Nombre = pNombre;
            TicketDelCliente = pTicket;
        }
        public string? Nombre { get; set; }
        public Ticket TicketDelCliente { get; set; }
        public Cliente? Siguiente { get; set; }
    }
}
