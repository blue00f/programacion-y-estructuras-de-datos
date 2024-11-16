using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class ListaSE
    {
        Alumno c;
        public ListaSE()
        {
            c = new Alumno();
        }

        public void AgregarAlPrincipio(Alumno pAlumno)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pAlumno;
            }
            else
            {
                pAlumno.Siguiente = c.Siguiente;
                c.Siguiente = pAlumno;
            }
        }
        public void AgregarAlFinal(Alumno pAlumno)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pAlumno;
            }
            else
            {
                RetornaUltimo().Siguiente = pAlumno;
            }
        }

        public void AgregarPosicionN(Alumno pAlumno, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion == 1) AgregarAlPrincipio(pAlumno);
                if (pPosicion == Cantidad() + 1) AgregarAlFinal(pAlumno);
                else if (pPosicion > 1 && pPosicion < Cantidad() + 1)
                {
                    Alumno aux = RetornaPosicionN(pPosicion - 1);
                    pAlumno.Siguiente = aux.Siguiente;
                    aux.Siguiente = pAlumno;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BorrarAlPrincipio()
        {
            Alumno aux = RetornaPrimero();
            if (aux != null)
            {
                c.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
        }

        // Se puede modificar para que retorne el nodo eliminado y poder mostrarlo, en este caso no es necesario.
        public void BorrarAlFinal()
        {
            Alumno aux = RetornaPosicionN(Cantidad() - 1);
            if (aux != null)
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
                    Alumno aux1 = RetornaPosicionN(pPosicion - 1);
                    Alumno aux2 = RetornaPosicionN(pPosicion);
                    aux1.Siguiente = aux2.Siguiente;
                    aux2.Siguiente = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPosicionN(Alumno pAlumnoActualizado, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion > 1 || pPosicion < Cantidad() + 1)
                {
                    Alumno aux = RetornaPosicionN(pPosicion);
                    // Se pisan los valores del registro viejo con los nuevos datos ingresados por el usuario
                    aux.Nombre = pAlumnoActualizado.Nombre;
                    aux.Apellido = pAlumnoActualizado.Apellido;
                    aux.DNI = pAlumnoActualizado.DNI;
                    aux.FechaNacimiento = pAlumnoActualizado.FechaNacimiento;
                    aux.Direccion = pAlumnoActualizado.Direccion;
                    aux.Telefono = pAlumnoActualizado.Telefono;
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
        private int CantidadRecursiva(Alumno primerNodo)
        {
            int res = 1;
            if (primerNodo.Siguiente != null) res += CantidadRecursiva(primerNodo.Siguiente);
            return res;
        }

        private Alumno RetornaPosicionN(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaPosicionNRecursiva(c.Siguiente, pPosicion);
        }

        private Alumno RetornaPosicionNRecursiva(Alumno primerNodo, int pPosicion)
        {
            Alumno aux = primerNodo;
            if (pPosicion != 1) aux = RetornaPosicionNRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }
        public Alumno RetornaPrimero()
        {
            return c.Siguiente;
        }
        public Alumno RetornaUltimo()
        {
            return RetornaUltimoRecursiva(c.Siguiente);
        }
        private Alumno RetornaUltimoRecursiva(Alumno primerNodo)
        {
            Alumno auxAlumno = primerNodo;
            if (auxAlumno != null)
            {
                if (auxAlumno.Siguiente != null)
                {
                    auxAlumno = RetornaUltimoRecursiva(auxAlumno.Siguiente);
                }
            }
            return auxAlumno;
        }
    }
}
