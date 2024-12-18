using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola01
{
    internal class Persona
    {
        public enum Sexo
        {
            Masculino = 0,
            Femenino = 1,
        }

        public Persona()
        { Siguiente = null; Nombre=""; }
        public Persona(string? pNombre, Sexo pSexo) : this()
        {
            Nombre=pNombre;
            SexoPersona=pSexo;
        }
        public string? Nombre { get; set; }
        public Sexo SexoPersona { get; set; }
        public Persona? Siguiente { get; set; }
    }
}
