﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Paciente? Siguiente { get; set; }

        public Paciente(int id, string nombre, string apellido, string direccion, string telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Telefono = telefono;
            Siguiente = null;
        }

        public Paciente()
        {
            Id = 0;
            Nombre = null;
            Apellido = null;
            Direccion = null;
            Telefono = null;
            Siguiente = null;
        }

        public Paciente CloneTipado()
        {
            Paciente auxPaciente = (Paciente)this.MemberwiseClone();
            auxPaciente.Siguiente = null;
            return auxPaciente;
        }
    }
}