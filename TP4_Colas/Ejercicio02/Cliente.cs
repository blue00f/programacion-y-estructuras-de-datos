using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02;
public class Cliente
{
    public string Nombre { get; set; }
    public int? Prioridad { get; set; }
    public Cliente? Siguiente { get; set; }
    
    public Cliente()
    {
        Nombre = "";
        Prioridad = null;
        Siguiente = null;
    }
    public Cliente(string pNombre, int? pPrioridad) : this()
    {
        Nombre = pNombre;
        Prioridad = pPrioridad;
        Siguiente = null;
    }
}
