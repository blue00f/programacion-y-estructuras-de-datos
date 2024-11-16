using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class ListaDE
    {
        Paciente c;
        public ListaDE()
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
                Paciente primerNodo = c.Siguiente;
                pPaciente.Siguiente = c.Siguiente;
                primerNodo.Anterior = pPaciente;
                c.Siguiente = pPaciente;
            }
        }
        public void AgregarPosicionN(Paciente pPaciente, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) AgregarAlPrincipio(pPaciente);
                else
                {
                    Paciente nodo = RetornaPosicionN(pPosicion);
                    Paciente nodoAnterior = nodo.Anterior;

                    pPaciente.Siguiente = nodo;
                    pPaciente.Anterior = nodo.Anterior;
                    nodoAnterior.Siguiente = pPaciente; 
                    nodo.Anterior = pPaciente;
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
            if(aux.Siguiente == null)
            {
                c.Siguiente = null;
            }
            else if(aux != null)
            {
                c.Siguiente = aux.Siguiente;
                Paciente nuevoPrimerNodo = c.Siguiente;
                aux.Siguiente = null;
                nuevoPrimerNodo.Anterior = null;
            }
        }
        public void BorrarAlFinal()
        {
            Paciente ultimoNodo = RetornaPosicionN(Cantidad());
            Paciente anteriorAlUltimo = ultimoNodo.Anterior;
            if (ultimoNodo != null)
            {
                anteriorAlUltimo.Siguiente = null;
                ultimoNodo.Anterior = null;
            }
        }
        public void BorrarPosicionN(int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) BorrarAlPrincipio();
                else if (pPosicion == Cantidad()) BorrarAlFinal();
                else
                {
                    Paciente nodoABorrar = RetornaPosicionN(pPosicion);
                    Paciente nodoAnterior = nodoABorrar.Anterior;
                    Paciente nodoSiguiente = nodoABorrar.Siguiente;

                    nodoAnterior.Siguiente = nodoABorrar.Siguiente;
                    nodoSiguiente.Anterior = nodoABorrar.Anterior;
                    nodoABorrar.Siguiente = null;
                    nodoABorrar.Anterior = null;
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
                    Paciente aux = RetornaPosicionN(pPosicion);
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

        public Paciente RetornaPrimero()
        {
            return c.Siguiente;
        }
        private Paciente RetornaUltimo()
        {
            return RetornaUltimoRecursiva(c.Siguiente);
        }
        private Paciente RetornaUltimoRecursiva(Paciente primerNodo)
        {
            Paciente aux = primerNodo;
            if(aux != null)
            {
                if(aux.Siguiente != null)
                {
                    aux = RetornaUltimoRecursiva(aux.Siguiente);
                }
            }
            return aux;
        }
        private Paciente RetornaPosicionN(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaPosicionNRecursiva(c.Siguiente, pPosicion);
        }

        private Paciente RetornaPosicionNRecursiva(Paciente? primerNodo, int pPosicion)
        {
            Paciente aux = primerNodo;
            if (pPosicion != 1) aux = RetornaPosicionNRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }
    }
}
