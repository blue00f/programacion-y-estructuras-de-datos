using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class ListaSE
    {
        Cliente c;
        public ListaSE()
        {
            c = new Cliente();
        }

        public void AgregarAlPrincipio(Cliente pCliente)
        {
            if(c.Siguiente == null)
            {
                c.Siguiente = pCliente;
            }
            else
            {
                pCliente.Siguiente = c.Siguiente;
                c.Siguiente = pCliente;
            }
        }
        public void AgregarAlFinal(Cliente pCliente)
        {
            if(c.Siguiente == null)
            {
                c.Siguiente = pCliente;
            }
            else
            {
                RetornaUltimo().Siguiente = pCliente;
            }
        }
        public void AgregarPosicionN(Cliente pCliente, int pPosicion)
        {
            try
            {
                // El Cantidad()+1 sirve para agregar hacia abajo
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) AgregarAlPrincipio(pCliente);
                else if (pPosicion == Cantidad() + 1) AgregarAlFinal(pCliente);
                else if (pPosicion > 1 && pPosicion < Cantidad() + 1)
                {
                    Cliente aux = RetornaPosicionN(pPosicion - 1);
                    pCliente.Siguiente = aux.Siguiente;
                    aux.Siguiente = pCliente;
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
            if(aux != null)
            {
                c.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
            return aux;
        }
        public Cliente BorrarAlFinal()
        {
            Cliente aux = RetornaPosicionN(Cantidad()-1);
            if(aux != null)
            {
                aux.Siguiente = null;
            }
            return aux;
        }
        public Cliente BorrarPosicionN(int pPosicion)
        {
            try
            {
                Cliente aux = null;
                if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) aux = BorrarAlPrincipio();
                else if (pPosicion == Cantidad() && Cantidad() != 0) aux = BorrarAlFinal();
                else if (pPosicion > 1 && pPosicion < Cantidad())
                {
                    Cliente aux1 = RetornaPosicionN(pPosicion - 1);
                    Cliente aux2 = RetornaPosicionN(pPosicion);
                    aux1.Siguiente = aux2.Siguiente;
                    aux2.Siguiente = null;
                    aux = aux2;
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
        private Cliente RetornaUltimoRecursiva(Cliente? primerNodo)
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
