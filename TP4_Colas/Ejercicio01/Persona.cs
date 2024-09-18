using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Persona
    {
        public string? Nombre { get; set; }
        public Sexo SexoPersona { get; set; }
        public Persona? Siguiente { get; set; }
        public enum Sexo
        {
            Masculino = 0,
            Femenino = 1,
        }
        public Persona()
        { 
            Nombre = "";
            Siguiente = null;
        }
        public Persona(string? pNombre, Sexo pSexo) : this()
        {
            Nombre = pNombre;
            SexoPersona = pSexo;
        }
    }
}
