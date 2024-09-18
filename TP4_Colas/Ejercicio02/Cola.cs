using Ejercicio02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02;
internal class Cola
{
    Cliente centinela;
    public Cola()
    {
        centinela = new Cliente();
    }

    public void Encolar(string pNombre, int pPrioridad)
    {
        Cliente c = new Cliente(pNombre, pPrioridad);
        Cliente? aQuienEncolo = centinela;

        // Buscar la posición correcta para encolar según la prioridad  
        while (aQuienEncolo.Siguiente != null && aQuienEncolo.Siguiente.Prioridad <= pPrioridad)
        {
            aQuienEncolo = aQuienEncolo.Siguiente;
        }

        /*
        if(centinela.Siguiente == null)
        {
            aQuienEncolo = centinela;
        }
        else if(aQuienEncolo.Siguiente.Prioridad <= pPrioridad)
        {
            aQuienEncolo = BuscarUltimo();
        }
        */

        // Encolar el nuevo nodo  
        c.Siguiente = aQuienEncolo.Siguiente;
        aQuienEncolo.Siguiente = c;
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
        if (centinela.Siguiente != null) //Cola con Nodos
        {
            aQuienMuestro = new Cliente(centinela.Siguiente.Nombre, centinela.Siguiente.Prioridad);
        }
        return aQuienMuestro;
    }

    private Cliente BuscarUltimo()
    {
        return BuscarUltimoRecursiva(centinela.Siguiente);
    }

    private Cliente BuscarUltimoRecursiva(Cliente pCliente)
    {
        Cliente c = pCliente;
        if (c.Siguiente != null)
        {
            c = BuscarUltimoRecursiva(c.Siguiente);
        }
        return c;
    }

    public Cliente? ObtenerPrimerNodo()
    {
        return centinela.Siguiente;
    }
}