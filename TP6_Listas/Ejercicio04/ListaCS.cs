using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class ListaCS
    {
        Jugador c;
        public ListaCS()
        {
            c = new Jugador();
        }

        public void AgregarAlPrincipio(Jugador pJugador)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pJugador;
                pJugador.Siguiente = pJugador;
            }
            else
            {
                pJugador.Siguiente = c.Siguiente;
                c.Siguiente = pJugador;
                RetornaUltimo().Siguiente = pJugador;
            }
        }
        public void AgregarAlFinal(Jugador pJugador)
        {
            if (c.Siguiente == null)
            {
                c.Siguiente = pJugador;
                pJugador.Siguiente = pJugador;
            }
            else
            {
                RetornaUltimo().Siguiente = pJugador;
                pJugador.Siguiente = c.Siguiente;
            }
        }
        public void AgregarPosicionN(Jugador pJugador, int pPosicion)
        {
            try
            {
                // El Cantidad()+1 sirve para agregar hacia abajo
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion == 1) AgregarAlPrincipio(pJugador);
                if (pPosicion == Cantidad() + 1) AgregarAlFinal(pJugador);
                else if (pPosicion > 1 && pPosicion < Cantidad())
                {
                    Jugador aux = RetornaPosicionN(pPosicion - 1);
                    pJugador.Siguiente = aux.Siguiente;
                    aux.Siguiente = pJugador;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Jugador BorrarAlPrincipio()
        {
            Jugador aux = RetornaPrimero();
            if(Cantidad() == 1)
            {
                c.Siguiente = null;
            }
            else
            {
                Jugador ultimoNodo = RetornaUltimo();
                c.Siguiente = aux.Siguiente;
                aux.Siguiente = null;
                ultimoNodo.Siguiente = c.Siguiente;
            }
            return aux;
        }
        public Jugador BorrarAlFinal()
        {
            Jugador aux = RetornaUltimo();
            Jugador anteultimo = RetornaPosicionN(Cantidad() - 1);
            if (aux != null)
            {
                aux.Siguiente = null;
                anteultimo.Siguiente = c.Siguiente;
            }
            return aux;
        }
        public Jugador BorrarPosicionN(int pPosicion)
        {
            try
            {
                Jugador nodoEliminado = null;
                if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");

                if (pPosicion == 1) nodoEliminado = BorrarAlPrincipio();
                else if (pPosicion == Cantidad()) nodoEliminado = BorrarAlFinal();
                else if (pPosicion > 1 && pPosicion < Cantidad())
                {
                    Jugador aux1 = RetornaPosicionN(pPosicion - 1); // Recupero el nodo anterior a eliminar
                    Jugador aux2 = aux1.Siguiente; // Recupero el nodo a eliminar
                    aux1.Siguiente = aux2.Siguiente;
                    aux2.Siguiente = null;
                    nodoEliminado = aux2;
                }
                return nodoEliminado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ModificarPosicionN(Jugador pJugadorActualizado, int pPosicion)
        {
            try
            {
                if (pPosicion < 1 || pPosicion > Cantidad() + 1) throw new Exception("La posición no es válida!");
                if (pPosicion >= 1 || pPosicion <= Cantidad())
                {
                    Jugador aux = RetornaPosicionN(pPosicion);
                    aux.Nombre = pJugadorActualizado.Nombre;
                    aux.Apellido = pJugadorActualizado.Apellido;
                    aux.Edad = pJugadorActualizado.Edad;
                    aux.Dni = pJugadorActualizado.Dni;
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

        private int CantidadRecursiva(Jugador primerNodo)
        {
            int res = 1;
            // Al ser circular, el caso base en vez de que el ultimo nodo apunte a null debe apuntar al primer nodo de la lista (c.Siguiente)
            if (primerNodo.Siguiente != c.Siguiente) res += CantidadRecursiva(primerNodo.Siguiente);
            return res;
        }
        

        public Jugador RetornaPrimero()
        {
            return c.Siguiente;
        }
        private Jugador RetornaUltimo()
        {
            Jugador aux;
            if (Cantidad() == 1)
            {
                aux = RetornaPrimero();
            }
            else
            {
                aux = RetornaUltimoRecursiva(c.Siguiente);
            }
            return aux;
        }

        private Jugador RetornaUltimoRecursiva(Jugador? primerNodo)
        {
            
            Jugador aux = primerNodo;
            if (aux.Siguiente != c.Siguiente) // Al ser una lista circular, el ultimo nodo apuntará al inicio de la lista (c.siguiente)
            {
                aux = RetornaUltimoRecursiva(aux.Siguiente);
            }
            return aux;
        }
        private Jugador RetornaPosicionN(int pPosicion)
        {
            if (pPosicion < 1 || pPosicion > Cantidad()) throw new Exception("La posición no es válida!");
            return RetornaPosicionNRecursiva(c.Siguiente, pPosicion);
        }

        private Jugador RetornaPosicionNRecursiva(Jugador? primerNodo, int pPosicion)
        {
            Jugador aux = primerNodo;
            if (pPosicion != 1) aux = RetornaPosicionNRecursiva(primerNodo.Siguiente, pPosicion - 1);
            return aux;
        }
    }
}
