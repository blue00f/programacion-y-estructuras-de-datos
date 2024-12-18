using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE01
{
    internal class ListaSE
    {
        Expediente C;
        public ListaSE() { C=new Expediente(); }
        public void AgregarAlPrincipio(Expediente pExpediente)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pExpediente;
            }
            else //Lista con al menos un Expediente
            { 
                pExpediente.Siguiente = C.Siguiente;
                C.Siguiente= pExpediente;
            }

        }
        public void AgregarAlFinal(Expediente pExpediente)
        {

            if (C.Siguiente==null) //Lista Vacía
            {
                C.Siguiente=pExpediente;
            }
            else //Lista con al menos un Expediente
            {
                RetornaUltimo().Siguiente = pExpediente;
               

            }

        }
        public void AgregarPosicionN(Expediente pExpediente, int pPos)
        {

            try
            {
                if (pPos<1 || pPos>Cantidad()+1) throw new Exception("La posición es inválida !!!"); //Escenario no posible
                //Estamos en condiciones de evaluar los distintos escenarios de insertar en Pos N
                if (pPos==1) AgregarAlPrincipio(pExpediente); //Si pPos==1 llamamos a Agregar al principio
                if (pPos==Cantidad()+1) AgregarAlFinal(pExpediente); //Si pPos==Cantidad()+1 llamamos a Agregar al final
                else if (pPos>1 && pPos<Cantidad()+1)
                {
                    Expediente aux = RetornaExpedientePosNInterna(pPos-1); //Expediente que se encuentra en la posición anterior al lugar que deseo insertar el nuevo Expediente
                    pExpediente.Siguiente=aux.Siguiente; 
                    aux.Siguiente=pExpediente;
                }
            }
            catch (Exception ex) { throw ex; }

            

        }

        public Expediente RetornaExpedientePosN(int pPos)
        {
            if (pPos<1 || pPos>Cantidad()) throw new Exception("La posición es inválida !!!"); //Escenario no posible
            return RetornaExpedientePosNRecursiva(C.Siguiente, pPos).CloneTipado();
        }
        private Expediente RetornaExpedientePosNInterna(int pPos)
        {
            if (pPos<1 || pPos>Cantidad()) throw new Exception("La posición es inválida !!!"); //Escenario no posible
            return RetornaExpedientePosNRecursiva(C.Siguiente, pPos);
        }
        private Expediente RetornaExpedientePosNRecursiva(Expediente pExpediente, int pPos)
        {
            Expediente aux = pExpediente;
            if (pPos!=1) aux = RetornaExpedientePosNRecursiva(pExpediente.Siguiente, pPos-1);
            return aux;
        }
        public Expediente RetornaPrimero() { return C.Siguiente; }
        public Expediente? RetornaUltimo()
        {
            return RetornaUltimoRecursiva(C.Siguiente);
        }
        public int Cantidad()
        {
            int rdo = 0;
            if(C.Siguiente!=null) rdo = CantidadRecursiva(C.Siguiente);
            return rdo; 
        }
        private int CantidadRecursiva(Expediente pExpediente)
        {
            int rdo = 1;
            if (pExpediente.Siguiente!=null) rdo+=CantidadRecursiva(pExpediente.Siguiente);
            return rdo;
        }
        private Expediente? RetornaUltimoRecursiva(Expediente? pExpediente)
        {
            Expediente? auxExpediente = pExpediente;
            if (auxExpediente !=null)
            {
                if (auxExpediente.Siguiente!=null) auxExpediente = RetornaUltimoRecursiva(auxExpediente.Siguiente);
            }
            return auxExpediente;
        }

    }
}
