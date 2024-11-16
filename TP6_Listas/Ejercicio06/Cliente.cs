using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Monto { get; set; }
        public Cliente? Anterior { get; set; }
        public Cliente? Siguiente { get; set; }
        public Cliente(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = GenerarEdad();
            Monto = CalcularMonto(Edad);
            Anterior = null;
            Siguiente = null;
        }
        public Cliente()
        {
            Nombre = null;
            Apellido = null;
            Edad = 0;
            Monto = 0;
            Anterior = null;
            Siguiente = null;
        }
        private int GenerarEdad()
        {
            Random rnd = new Random();
            return rnd.Next(5, 61);
        }
        private double CalcularMonto(int pEdad)
        {
            double precioBase = 3000;
            if (pEdad >= 5 && pEdad <= 13) precioBase = precioBase * 0.5;
            if (pEdad >= 50 && pEdad <= 60) precioBase = precioBase * 0.75;
            return precioBase;
        }
        public Cliente CloneTipado()
        {
            Cliente auxCliente = (Cliente)this.MemberwiseClone();
            auxCliente.Siguiente = null;
            return auxCliente;
        }
    }
}
