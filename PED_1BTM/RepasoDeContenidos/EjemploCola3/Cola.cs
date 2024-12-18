using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCola2
{
    internal class Cola
    {
        Coche centinela;
        public Cola()
        {
            centinela = new Coche();
        }

        public void Encolar(string modelo, Coche.Motor motor)
        {
            Coche coche = new Coche(modelo, motor);

            if(centinela.Siguiente == null)
            {
                centinela.Siguiente = coche;
            }
            else
            {
                BuscarUltimo().Siguiente = coche;
            }
        }
        public Coche? Desencolar()
        {
            Coche coche = null;
            if(centinela.Siguiente != null)
            {
                coche = centinela.Siguiente;
                centinela.Siguiente = coche.Siguiente;
                coche.Siguiente = null;
            }
            return coche;
        }
        public Coche Ver()
        {
            Coche coche = null;
            if(centinela.Siguiente != null)
            {
                coche = new Coche(centinela.Siguiente.Modelo, centinela.Siguiente.TipoMotor);
            }
            return coche;
        }
        private Coche BuscarUltimo()
        {
            return BuscarUltimoRecursiva(centinela.Siguiente);
        }
        private Coche BuscarUltimoRecursiva(Coche primerCoche)
        {
            Coche coche = primerCoche;
            if(coche.Siguiente != null)
            {
                coche = BuscarUltimoRecursiva(coche.Siguiente);
            }
            return coche;
        }
    }
}
