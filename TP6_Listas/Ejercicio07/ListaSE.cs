using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class ListaSE
    {
        Nodo c;
        public ListaSE()
        {
            c = new Nodo();
        }

        public void AgregarAlPrincipio(Nodo pNodo)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pNodo;
            }
            else
            {
                pNodo.Siguiente = c.Siguiente;
                c.Siguiente = pNodo;
            }
        }
        public void AgregarAlFinal(Nodo pNodo)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pNodo;
            }
            else
            {
                RetornaUltimo().Siguiente = pNodo;
            }
        }

        public void AgregarPosicionN(Nodo pNodo, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion == 1) AgregarAlPrincipio(pNodo);
                if (pPosicion == Cantidad() + 1) AgregarAlFinal(pNodo);
                else if (pPosicion > 1 && pPosicion < Cantidad() + 1)
                {
                    Nodo aux = RetornaPosicionN(pPosicion - 1);
                    pNodo.Siguiente = aux.Siguiente;
                    aux.Siguiente = pNodo;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BorrarAlPrincipio()
        {
            Nodo aux = RetornaPrimero();
            if (aux != null)
            {
                c.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
            }
        }

        public void BorrarAlFinal()
        {
            Nodo aux = RetornaPosicionN(Cantidad() - 1);
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
                    Nodo aux1 = RetornaPosicionN(pPosicion - 1);
                    Nodo aux2 = RetornaPosicionN(pPosicion);
                    aux1.Siguiente = aux2.Siguiente;
                    aux2.Siguiente = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPosicionN(Nodo pNodoActualizado, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion > 1 || pPosicion < Cantidad() + 1)
                {
                    Nodo aux = RetornaPosicionN(pPosicion);
                    // Se pisan los valores del registro viejo con los nuevos datos ingresados por el usuario
                    aux.Nombre = pNodoActualizado.Nombre;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // En este caso el número será la posición de la fila seleccionada en la grilla, también coincide con el número de ID
        public void IntercambiarDerecha(int numero)
        {
            try
            {
                if (numero < 1 || numero > Cantidad() + 1) throw new Exception("El número no es valido!");
                if (numero == Cantidad()) throw new Exception("No se puede intercambiar por derecha porque no hay un nodo para intercambiar!");

                if (numero == 1)
                {
                    Nodo primerNodo = c.Siguiente;
                    Nodo segundoNodo = primerNodo.Siguiente;

                    c.Siguiente = segundoNodo;
                    primerNodo.Siguiente = segundoNodo.Siguiente;
                    segundoNodo.Siguiente = primerNodo;
                }
                else
                {
                    Nodo nodoAIntercambiar = RetornaPosicionN(numero);
                    Nodo nodoIzquierda = RetornaPosicionN(numero - 1);
                    Nodo nodoDerecha = nodoAIntercambiar.Siguiente;

                    nodoIzquierda.Siguiente = nodoAIntercambiar.Siguiente;
                    nodoAIntercambiar.Siguiente = nodoDerecha.Siguiente;
                    nodoDerecha.Siguiente = nodoAIntercambiar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void IntercambiarIzquierda(int numero)
        {
            try
            {
                if (numero < 1 || numero > Cantidad() + 1) throw new Exception("El número no es valido!");
                if (numero == 1) throw new Exception("No se puede intercambiar por izquierda porque no hay un nodo para intercambiar!");

                if (numero == Cantidad())
                {
                    Nodo ultimoNodo = RetornaPosicionN(Cantidad());
                    Nodo nodoIzquierda = RetornaPosicionN(Cantidad() - 1);
                    Nodo nodoIzquierdaDosVeces = RetornaPosicionN(Cantidad() - 2);

                    nodoIzquierdaDosVeces.Siguiente = ultimoNodo;
                    nodoIzquierda.Siguiente = null;
                    ultimoNodo.Siguiente = nodoIzquierda;
                }
                else if(numero == 2)
                {
                    Nodo primerNodo = c.Siguiente;
                    Nodo nodoAIntercambiar = primerNodo.Siguiente;

                    c.Siguiente = nodoAIntercambiar;
                    primerNodo.Siguiente = nodoAIntercambiar.Siguiente;
                    nodoAIntercambiar.Siguiente = primerNodo;
                }
                else
                {
                    Nodo nodoAIntercambiar = RetornaPosicionN(numero);
                    Nodo nodoIzquierda = RetornaPosicionN(numero - 1);
                    Nodo nodoIzquierdaDosVeces = RetornaPosicionN(numero - 2);

                    nodoIzquierdaDosVeces.Siguiente = nodoAIntercambiar;
                    nodoIzquierda.Siguiente = nodoAIntercambiar.Siguiente;
                    nodoAIntercambiar.Siguiente = nodoIzquierda;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Intercambiar(int numero1, int numero2)
        {
            try
            {
                if (numero1 < 1 || numero1 > Cantidad() + 1) throw new Exception("El número no es valido!");
                else if (numero2 < 1 || numero2 > Cantidad() + 1) throw new Exception("El número no es valido!");
                else if (numero1 == numero2) throw new Exception("No se puede intercambiar el mismo número!");

                if(numero1 == 1)
                {
                    Nodo nodo1 = c.Siguiente;
                    Nodo sigNodo1 = nodo1.Siguiente;
                    Nodo nodo2 = RetornaPosicionN(numero2);
                    Nodo antNodo2 = RetornaPosicionN(numero2-1);
                    Nodo sigNodo2 = nodo2.Siguiente;

                    nodo1.Siguiente = nodo2.Siguiente;
                    nodo2.Siguiente = sigNodo1;
                    antNodo2.Siguiente = nodo1;
                    c.Siguiente = nodo2;
                }

                // Si se quiere intercambiar el primer y ultimo nodo de la lista
                else if(numero1 == 1 && numero2 == Cantidad() || numero1 == Cantidad() && numero2 == 1)
                {
                    Nodo primerNodo = c.Siguiente;
                    Nodo ultimoNodo = RetornaPosicionN(Cantidad());
                    Nodo penultimoNodo = RetornaPosicionN(Cantidad() - 1);

                    ultimoNodo.Siguiente = c.Siguiente;
                    penultimoNodo.Siguiente = c.Siguiente;
                    c.Siguiente = ultimoNodo;
                    ultimoNodo.Siguiente = primerNodo.Siguiente;
                    primerNodo.Siguiente = null;
                }

                // Si entre el nodo1 y nodo2 a intercambiar hay un espacio de un nodo, comparten un nodo en común
                else if (numero1-numero2 == 2 || numero2-numero1 == 2)
                {
                    Nodo nodo1 = RetornaPosicionN(numero1);
                    Nodo nodo2 = RetornaPosicionN(numero2);
                    Nodo antNodo1 = RetornaPosicionN(numero1 - 1);
                    Nodo sigNodo2 = nodo2.Siguiente;
                    Nodo nodoComun = nodo1.Siguiente; // También es el anterior del nodo2, por eso es un nodo común

                    antNodo1.Siguiente = nodo2;
                    Nodo aux = nodo2.Siguiente;
                    nodo2.Siguiente = nodo1.Siguiente;
                    nodoComun.Siguiente = nodo1;
                    nodo1.Siguiente = aux;
                }

                // Si entre el nodo1 y nodo2 tienen un espacio mayor a 1, no comparten un nodo en común
                else if (numero1 > 1 && numero2 < Cantidad())
                {
                    Nodo antNodo1 = RetornaPosicionN(numero1 - 1);
                    Nodo nodo1 = RetornaPosicionN(numero1);
                    Nodo sigNodo1 = nodo1.Siguiente;

                    Nodo antNodo2 = RetornaPosicionN(numero2 - 1);
                    Nodo nodo2 = RetornaPosicionN(numero2);
                    Nodo sigNodo2 = nodo2.Siguiente;

                    antNodo1.Siguiente = nodo2;
                    Nodo aux = nodo1.Siguiente;
                    nodo1.Siguiente = nodo2.Siguiente;

                    nodo2.Siguiente = aux;
                    antNodo2.Siguiente = nodo1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int Cantidad()
        {
            int res = 0;
            if (c.Siguiente != null) res = CantidadRecursiva(c.Siguiente);
            return res;
        }
        private int CantidadRecursiva(Nodo primerNodo)
        {
            int res = 1;
            if (primerNodo.Siguiente != null) res += CantidadRecursiva(primerNodo.Siguiente);
            return res;
        }

        private Nodo RetornaPosicionN(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaPosicionNRecursiva(c.Siguiente, pPosicion);
        }

        private Nodo RetornaPosicionNRecursiva(Nodo primerNodo, int pPosicion)
        {
            Nodo aux = primerNodo;
            if (pPosicion != 1) aux = RetornaPosicionNRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }

        public Nodo RetornaPrimero()
        {
            return c.Siguiente;
        }
        public Nodo RetornaUltimo()
        {
            return RetornaUltimoRecursiva(c.Siguiente);
        }
        private Nodo RetornaUltimoRecursiva(Nodo primerNodo)
        {
            Nodo auxPaciente = primerNodo;
            if (auxPaciente != null)
            {
                if (auxPaciente.Siguiente != null)
                {
                    auxPaciente = RetornaUltimoRecursiva(auxPaciente.Siguiente);
                }
            }
            return auxPaciente;
        }
    }
}