using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03;

internal class Cola
{
    Cliente centinela;
    public Cola() { centinela = new Cliente(); }
    public void Encolar(string pNombre, Cliente.Ticket pTicket)
    {
        Cliente? n = new Cliente(pNombre, pTicket);
        Cliente? aQuienEncolo;
        if (centinela.Siguiente == null)
        {
            aQuienEncolo = centinela;
        }
        else
        {
            aQuienEncolo = BuscarUltimo();
        }
        aQuienEncolo.Siguiente = n;
    }

    public Cliente? Desencolar()
    {
        Cliente? aQuienSaco = null;
        if (centinela.Siguiente != null)
        {
            aQuienSaco = centinela.Siguiente;
            centinela.Siguiente = aQuienSaco.Siguiente;
            aQuienSaco.Siguiente = null;
        }
        return aQuienSaco;
    }
    public Cliente? Ver()
    {
        Cliente? aQuienMuestro = null;
        if (centinela.Siguiente != null)
        {
            aQuienMuestro = new Cliente(centinela.Siguiente.Nombre, centinela.Siguiente.TicketDelCliente);
        }
        return aQuienMuestro;
    }
    private Cliente? BuscarUltimo()
    {
        return BuscarUltimoRecursiva(centinela.Siguiente);
    }

    private Cliente? BuscarUltimoRecursiva(Cliente? pNodo)
    {
        Cliente? n = pNodo;
        if (n.Siguiente != null)
        {
            n = BuscarUltimoRecursiva(n.Siguiente);
        }
        return n;
    }
}
