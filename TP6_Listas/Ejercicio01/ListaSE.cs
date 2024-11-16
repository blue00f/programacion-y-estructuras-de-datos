using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class ListaSE
    {
        Paciente c;
        public ListaSE()
        {
            c = new Paciente();
        }

        public void AgregarAlPrincipio(Paciente pPaciente)
        {
            if(c.Siguiente == null)
            {
                c.Siguiente = pPaciente;
            }
            else
            {
                pPaciente.Siguiente = c.Siguiente;
                c.Siguiente = pPaciente;
            }
        }
        public void AgregarAlFinal(Paciente pPaciente)
        {
            if(c.Siguiente == null)
            {
                c.Siguiente = pPaciente;
            }
            else
            {
                RetornaUltimo().Siguiente = pPaciente;
            }
        }

        public void AgregarPosicionN(Paciente pPaciente, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion == 1) AgregarAlPrincipio(pPaciente);
                if (pPosicion == Cantidad() + 1) AgregarAlFinal(pPaciente);
                else if (pPosicion > 1 && pPosicion < Cantidad() + 1)
                {
                    Paciente aux = RetornaNodoPosNInterna(pPosicion - 1);
                    pPaciente.Siguiente = aux.Siguiente;
                    aux.Siguiente = pPaciente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BorrarAlPrincipio()
        {
            Paciente aux = RetornaPrimero();
            if(aux != null)
            {
                c.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
        }

        // Se puede modificar para que retorne el nodo eliminado y poder mostrarlo, en este caso no es necesario.
        public void BorrarAlFinal()
        {
            Paciente aux = RetornaNodoPosNInterna(Cantidad() - 1);
            if(aux != null)
            {
                aux.Siguiente = null;
            }
        }

        public void BorrarPosicionN(int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) BorrarAlPrincipio();
                // nota: la condicion "Cantidad() != 0" es para que no se ejecuten en simultaneo el BorrarAlPrincipio y BorrarAlFinal 
                else if (pPosicion == Cantidad() && Cantidad() != 0) BorrarAlFinal();
                else if (pPosicion > 1 && pPosicion < Cantidad())
                {
                    Paciente aux1 = RetornaNodoPosNInterna(pPosicion - 1);
                    Paciente aux2 = RetornaNodoPosNInterna(pPosicion);
                    aux1.Siguiente = aux2.Siguiente;
                    aux2.Siguiente = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPosicionN(Paciente pPacienteActualizado, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion > 1 || pPosicion < Cantidad() + 1)
                {
                    Paciente aux = RetornaNodoPosNInterna(pPosicion);
                    // Se pisan los valores del registro viejo con los nuevos datos ingresados por el usuario
                    aux.Id = pPacienteActualizado.Id;
                    aux.Nombre = pPacienteActualizado.Nombre;
                    aux.Apellido = pPacienteActualizado.Apellido;
                    aux.Direccion = pPacienteActualizado.Direccion;
                    aux.Telefono = pPacienteActualizado.Telefono;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Cantidad()
        {
            int res = 0;
            if (c.Siguiente != null) res = CantidadRecursiva(c.Siguiente);
            return res;
        }
        private int CantidadRecursiva(Paciente primerNodo)
        {
            int res = 1;
            if (primerNodo.Siguiente != null) res += CantidadRecursiva(primerNodo.Siguiente);
            return res;
        }

        private Paciente RetornaNodoPosNInterna(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaNodoPosNInternaRecursiva(c.Siguiente, pPosicion);
        }

        private Paciente RetornaNodoPosNInternaRecursiva(Paciente primerNodo, int pPosicion)
        {
            Paciente aux = primerNodo;
            if (pPosicion != 1) aux = RetornaNodoPosNInternaRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }

        

        public Paciente RetornaPrimero()
        {
            return c.Siguiente;
        }
        public Paciente RetornaUltimo()
        {
            return RetornaUltimoRecursiva(c.Siguiente);
        }
        private Paciente RetornaUltimoRecursiva(Paciente primerNodo)
        {
            Paciente auxPaciente = primerNodo;
            if(auxPaciente != null)
            {
                if(auxPaciente.Siguiente != null)
                {
                    auxPaciente = RetornaUltimoRecursiva(auxPaciente.Siguiente);
                }
            }
            return auxPaciente;
        }
    }
}
