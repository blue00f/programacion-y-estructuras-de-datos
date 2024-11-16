using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class ListaDE
    {
        Cliente c;
        public ListaDE()
        {
            c = new Cliente();
        }
        public void AgregarAlPrincipio(Cliente pCliente)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pCliente;
            }
            else
            {
                Cliente primerNodo = c.Siguiente;
                pCliente.Siguiente = c.Siguiente;
                primerNodo.Anterior = pCliente;
                c.Siguiente = pCliente;
            }
        }
        public void AgregarPosicionN(Cliente pCliente, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) AgregarAlPrincipio(pCliente);
                else
                {
                    Cliente nodo = RetornaPosicionN(pPosicion);
                    Cliente nodoAnterior = nodo.Anterior;

                    pCliente.Siguiente = nodo;
                    pCliente.Anterior = nodo.Anterior;
                    nodoAnterior.Siguiente = pCliente;
                    nodo.Anterior = pCliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente BorrarAlPrincipio()
        {
            Cliente aux = RetornaPrimero();
            if (aux.Siguiente == null)
            {
                c.Siguiente = null;
            }
            else if (aux != null)
            {
                c.Siguiente = aux.Siguiente;
                Cliente nuevoPrimerNodo = c.Siguiente;
                aux.Siguiente = null;
                nuevoPrimerNodo.Anterior = null;
            }
            return aux;
        }
        public Cliente BorrarAlFinal()
        {
            Cliente ultimoNodo = RetornaPosicionN(Cantidad());
            Cliente anteriorAlUltimo = ultimoNodo.Anterior;
            if (ultimoNodo != null)
            {
                anteriorAlUltimo.Siguiente = null;
                ultimoNodo.Anterior = null;
            }
            return ultimoNodo;
        }
        public Cliente BorrarPosicionN(int pPosicion)
        {
            try
            {
                Cliente aux;
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) aux = BorrarAlPrincipio();
                else if (pPosicion == Cantidad()) aux = BorrarAlFinal();
                else
                {
                    Cliente nodoABorrar = RetornaPosicionN(pPosicion);
                    Cliente nodoAnterior = nodoABorrar.Anterior;
                    Cliente nodoSiguiente = nodoABorrar.Siguiente;

                    nodoAnterior.Siguiente = nodoABorrar.Siguiente;
                    nodoSiguiente.Anterior = nodoABorrar.Anterior;
                    nodoABorrar.Siguiente = null;
                    nodoABorrar.Anterior = null;
                    aux = nodoABorrar;
                }
                return aux;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarPosicionN(Cliente pClienteActualizado, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion > 1 || pPosicion < Cantidad() + 1)
                {
                    Cliente aux = RetornaPosicionN(pPosicion);
                    aux.Nombre = pClienteActualizado.Nombre;
                    aux.Apellido = pClienteActualizado.Apellido;
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
        private int CantidadRecursiva(Cliente primerNodo)
        {
            int res = 1;
            if (primerNodo.Siguiente != null) res += CantidadRecursiva(primerNodo.Siguiente);
            return res;
        }

        public Cliente RetornaPrimero()
        {
            return c.Siguiente;
        }
        private Cliente RetornaUltimo()
        {
            return RetornaUltimoRecursiva(c.Siguiente);
        }
        private Cliente RetornaUltimoRecursiva(Cliente primerNodo)
        {
            Cliente aux = primerNodo;
            if (aux != null)
            {
                if (aux.Siguiente != null)
                {
                    aux = RetornaUltimoRecursiva(aux.Siguiente);
                }
            }
            return aux;
        }
        private Cliente RetornaPosicionN(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaPosicionNRecursiva(c.Siguiente, pPosicion);
        }

        private Cliente RetornaPosicionNRecursiva(Cliente? primerNodo, int pPosicion)
        {
            Cliente aux = primerNodo;
            if (pPosicion != 1) aux = RetornaPosicionNRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }
    }
}
