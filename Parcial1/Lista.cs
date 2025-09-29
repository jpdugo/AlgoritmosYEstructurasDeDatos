using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Lista: ICloneable
    {
        Nodo centinela;
        public Lista()
        {
            centinela = new Nodo();
        }

        public void AgregarPrimero(Nodo pNodo)
        {
            Nodo nuevoNodo = pNodo.CloneTipado();
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = nuevoNodo;
            } else
            {
                Nodo nodoAux = centinela.Siguiente;
                centinela.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = nodoAux;
            }
        }

        public void AgregarUltimo(Nodo pNodo)
        {
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = pNodo.CloneTipado();
            }else
            {
                Nodo ultimoNodo = BuscarPosN(Cantidad());
                ultimoNodo.Siguiente = pNodo.CloneTipado();
            }
        }

        public Nodo BorrarPrimero()
        {
            Nodo nodoAux = null;
            if (centinela.Siguiente != null)
            {
                nodoAux = centinela.Siguiente;
                centinela.Siguiente = nodoAux.Siguiente;
                nodoAux.Siguiente = null;
            }
            return nodoAux;
        }

        public Nodo BorrarUltimo()
        {
            Nodo nodo = null;
            if (Cantidad() == 1)
            {
                nodo = centinela.Siguiente;
                centinela.Siguiente = null;
            }
            if (centinela.Siguiente != null)
            {
                Nodo nodoAnteUltimo = BuscarPosN(Cantidad() - 1);
                nodo = nodoAnteUltimo.Siguiente;
                nodoAnteUltimo.Siguiente = null;
            }
            return nodo;
        }

        private Nodo BuscarPosN(int pos)
        {
            return BuscarPosNRecursivo(centinela.Siguiente, pos);
        }

        private Nodo BuscarPosNRecursivo(Nodo pNodo, int pos)
        {
            if (pos > 1) {
                pNodo = BuscarPosNRecursivo(pNodo.Siguiente, pos - 1);
            }
            return pNodo;
        }

        public int Cantidad()
        {
            return CantidadRecursivo(centinela, 0);
        }

        private int CantidadRecursivo(Nodo pNodo, int largo)
        {
            if (pNodo.Siguiente != null) {
                largo = CantidadRecursivo(pNodo.Siguiente, largo + 1);
            }
            // cuando llegas al final de todo largo ya viene acumulado
            return largo;
        }

        public object Clone()
        {
            Lista listaNueva = new Lista();
            return ClonarRecursivo(listaNueva, centinela.Siguiente);
            
        }

        public Lista CloneTipado() => (Lista)this.Clone();

        public Lista ClonarRecursivo(Lista pLista, Nodo pNodo)
        {
            if (pNodo != null)
            {
                pLista.AgregarUltimo(pNodo);
                pLista = ClonarRecursivo(pLista, pNodo.Siguiente);
            }
            return pLista;
        }

        public int ContarWhile()
        {
            int contador = 0;
            Nodo nodoAux = centinela;
            while((nodoAux = nodoAux.Siguiente) != null) {
                contador++;
            }
            return contador;
        }

        public void Swap(int posIzq, int posDer)
        {
            if (posIzq > posDer)
            {
                int posAux = posDer;
                posDer = posIzq;
                posIzq = posAux;
            }

            if (posIzq > 0 && posDer <= Cantidad() && posIzq != posDer)
            {
                if (posDer - posIzq == 1) // son contiguos
                {
                    if (posIzq == 1)
                    {
                        Nodo derecha = BuscarPosN(2);
                        Nodo izquierda = centinela.Siguiente;
                        izquierda.Siguiente = derecha.Siguiente;
                        centinela.Siguiente = derecha;
                        derecha.Siguiente = izquierda;
                    }
                    else if (posIzq > 1)
                    {
                        Nodo izquierdaAnterior = BuscarPosN(posIzq -1);
                        Nodo izquierda = izquierdaAnterior.Siguiente;
                        Nodo derecha = izquierda.Siguiente;
                        Nodo derechaSiguiente = derecha.Siguiente;

                        izquierdaAnterior.Siguiente = derecha;
                        derecha.Siguiente = izquierda;

                        
                    }
                }
                else if (posDer - posIzq > 1)
                {
                    Nodo izqAnterior = posIzq == 1 ? centinela : BuscarPosN(posIzq - 1);
                    Nodo izquierda = izqAnterior.Siguiente;
                    Nodo izqSiguiente = izquierda.Siguiente;

                    Nodo derAnterior = BuscarPosN(posDer - 1);
                    Nodo derecha = derAnterior.Siguiente;
                    Nodo derechaSiguiente = derecha.Siguiente;


                    izqAnterior.Siguiente = derecha;
                    derecha.Siguiente = izqSiguiente;
                    // en este punto perdi derecha.siguiente si no lo guarde
                    derAnterior.Siguiente = izquierda;
                    izquierda.Siguiente = derechaSiguiente;
                }
            }
        }
    }
}
