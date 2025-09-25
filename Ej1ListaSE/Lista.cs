using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ej1ListaSE
{
    internal class Lista
    {
        Nodo centinela;

        public Lista()
        {
            centinela = new Nodo();
        }

        public void AgregarPrimero(Nodo pNodo)
        {
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = pNodo.CloneTipado();
            }
            else {
                Nodo nodoAux = centinela.Siguiente;
                centinela.Siguiente = pNodo.CloneTipado();
                centinela.Siguiente.Siguiente = nodoAux;
            }
        }

        public void AgregarUltimo(Nodo pNodo) {
            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = pNodo.CloneTipado();
            }
            else
            {
                BuscarUltimoRecursivo(centinela.Siguiente).Siguiente = pNodo.CloneTipado();
            }
        }

        public bool AgregarEnPosN(Nodo pNodo, int pos)
        {
            int cantidad = Cantidad();

            bool exito = false;
            
            if (pos == 1)
            {
                AgregarPrimero(pNodo);
                exito = true;

            } else if (pos == cantidad + 1)
            {
                AgregarUltimo(pNodo);
                exito = true;
            } else if (pos <= cantidad)
            {
                Nodo nodoAnterior = BuscarPosN(pos - 1);
                Nodo nodoAux = nodoAnterior.Siguiente; // este es el nodo que ocupa la posicion y debe shiftear a la derecha 
                nodoAnterior.Siguiente = pNodo;
                pNodo.Siguiente = nodoAux;
                exito = true;
            }
            return exito;
        }

        private Nodo BuscarUltimoRecursivo(Nodo pNodo)
        {
            if(pNodo.Siguiente != null)
            {
                pNodo = BuscarUltimoRecursivo(pNodo.Siguiente);
            }
            return pNodo;
        }

        public Nodo BorrarPrimero()
        {
            Nodo nodo = null;
            if (centinela.Siguiente != null)
            {
                nodo = centinela.Siguiente; // copio el primer elemento en un nodo auxiliar
                centinela.Siguiente = nodo.Siguiente; // el segundo elemento de la lista pasa a ser el primero
                nodo.Siguiente = null; // quito la referencia al resto de la lista
            }
            return nodo;
        }

        public Nodo? BorrarUltimo()
        {
            Nodo nodo = null;
            if (centinela.Siguiente!= null)
            {
                int totalNodos = Cantidad();
                if (totalNodos == 1)
                {
                    nodo = BorrarPrimero();
                }
                else
                {
                    Nodo nodoAnteultimo = BuscarPosN(Cantidad() - 1);
                    nodo = nodoAnteultimo.Siguiente;
                    nodoAnteultimo.Siguiente = null;
                }

            }
            return nodo;
        }

        private Nodo BuscarAnteriorPosN(int pos) => BuscarPosN(pos - 1);

        public bool IntercambiarDerecha(int pos)
        {
            bool exito = false;
            int cantidad = Cantidad();

            if (pos > 0 && pos < cantidad)
            {
                
                if (pos == 1)
                {
                    Nodo primerNodo = centinela.Siguiente;
                    Nodo segundoNodo = primerNodo.Siguiente;

                    primerNodo.Siguiente = segundoNodo.Siguiente;
                    segundoNodo.Siguiente = primerNodo;
                    

                    centinela.Siguiente = segundoNodo;
                }

                else
                {
                    Nodo nodoAnterior = BuscarAnteriorPosN(pos);
                    Nodo nodoMoverDerecha = nodoAnterior.Siguiente;
                    Nodo nodoMoverIzquierda = nodoMoverDerecha.Siguiente;

                    // ahora quiero que:
                    // nodoAnterior.Siguiente apunte al nodoMoverIzquierda
                    // guardar el contenido de nodoMoverIzquierda.Siguiente en variable auxiliar
                    // nodoMoverIzquierda.Siguiente apunte al nodoMoverDerecha
                    // nodoMoverDerecha apunte al nodoMoverIzquierda.Siguiente

                    nodoAnterior.Siguiente = nodoMoverIzquierda;
                    Nodo nodoAuxiliar = nodoMoverIzquierda.Siguiente; // el resto de la lista para no perderla
                    nodoMoverIzquierda.Siguiente = nodoMoverDerecha;
                    nodoMoverDerecha.Siguiente= nodoAuxiliar;

                }


                exito = true;
            }

            return exito;
        }

        public bool IntercambiarIzquierda(int pos)
        {
            bool exito = false;
            if (pos > 2 && pos <= Cantidad())
            {
                Nodo nodoAnterior = BuscarAnteriorPosN(pos);
                Nodo nodoAnteriorAnterior = BuscarPosN(pos - 2);
                Nodo nodoPos = BuscarPosN(pos);

                // nodoAnteriorAnterior.Siguiente tiene que apuntar a nodoPos que esta a la derecha
                // guardar el siguiente de nodoPos en variable auxiliar
                // nodoPos.Siguiente tiene que apuntar a nodoAnterior
                // nodoAnterior.siguiente tiene que apuntar a nodoPos.siguiente

                nodoAnteriorAnterior.Siguiente = nodoPos;
                Nodo nodoAux = nodoPos.Siguiente;
                nodoPos.Siguiente = nodoAnterior;
                nodoAnterior.Siguiente = nodoAux;

                exito = true;
                
            }
            if (pos == 2)
            {
                Nodo nodoAnterior = BuscarAnteriorPosN(pos);
                Nodo nodoAnteriorAnterior = centinela;
                Nodo nodoPos = BuscarPosN(pos);

                // nodoAnteriorAnterior.Siguiente tiene que apuntar a nodoPos que esta a la derecha
                // guardar el siguiente de nodoPos en variable auxiliar
                // nodoPos.Siguiente tiene que apuntar a nodoAnterior
                // nodoAnterior.siguiente tiene que apuntar a nodoPos.siguiente

                nodoAnteriorAnterior.Siguiente = nodoPos;
                Nodo nodoAux = nodoPos.Siguiente;
                nodoPos.Siguiente = nodoAnterior;
                nodoAnterior.Siguiente = nodoAux;

                exito = true;
            }
            return exito;

        }

        public bool Swap(int posIzq , int posDer)
        {
            bool exito = false;
            if (centinela.Siguiente == null || Cantidad() == 1 || posIzq == posDer) { return exito; }
            
            if (posIzq > posDer)
            {
                int posAux = posDer;
                posDer = posIzq;
                posIzq = posAux;
            }

            if (posDer <= Cantidad())
            {
                if (posDer - posIzq == 1) // son contiguos
                {
                    exito = IntercambiarDerecha(posIzq);
                } else if (posDer - posIzq > 1) // no son contiguos es lo mas dificil
                {
                    Nodo nodoAnteriorIzq;
                    if (posIzq == 1)
                        nodoAnteriorIzq = centinela;
                    else
                        nodoAnteriorIzq = BuscarAnteriorPosN(posIzq);

                    Nodo nodoIzq = BuscarPosN(posIzq); // A
                    Nodo nodoIzqSiguienteAux = nodoIzq.Siguiente; // B

                    Nodo nodoAnteriorDer = BuscarAnteriorPosN(posDer); // C
                    Nodo nodoDer = nodoAnteriorDer.Siguiente; // D
                    Nodo nodoAuxDerSiguiente = nodoDer.Siguiente; // E


                    nodoAnteriorIzq.Siguiente = nodoDer;
                    nodoDer.Siguiente = nodoIzq.Siguiente;

                    nodoAnteriorDer.Siguiente = nodoIzq;
                    nodoIzq.Siguiente = nodoAuxDerSiguiente;

                    exito = true;
                }
            }

            return exito;
        }

        public int Cantidad()
        {
            return CantidadRecursivo(centinela, 0);
        }

        private int CantidadRecursivo(Nodo pNodo,int cantidad)
        {
            if (pNodo.Siguiente != null)
            {
                cantidad = CantidadRecursivo(pNodo.Siguiente, cantidad + 1); 
            }
            return cantidad;
        }

        private Nodo BuscarPosN(int n)
        {
            Nodo nodo = null;
            if (centinela.Siguiente != null && n <= Cantidad())
            {
                nodo = BuscarPosRecursivo(centinela.Siguiente, n);
            }
            return nodo;
        }

        public Nodo BuscarPosRecursivo(Nodo pNodo, int pos)
        {
           if (pos != 1)
            {
                pNodo = BuscarPosRecursivo(pNodo.Siguiente, pos - 1);
            }
           return pNodo;
        }

        public Lista Clonar()
        {
            Lista lclonar = new Lista();
            return ClonarListaRecursivo(lclonar, centinela.Siguiente);
        } 

        private Lista ClonarListaRecursivo(Lista lclonar, Nodo pNodo)
        {
            if (pNodo.Siguiente != null) // ojo con usar centinela aca!!
            {
                lclonar.AgregarUltimo(pNodo);
                lclonar = ClonarListaRecursivo(lclonar, pNodo.Siguiente);
            }
            return lclonar;
        }

        public Nodo BorrarEnPosN(int pos)
        {
            Nodo nodo = null;
            if (pos == 1)
            {
                nodo = BorrarPrimero();
            }
            else if (pos == Cantidad())
            {
                nodo = BorrarUltimo();
            }
            else if (pos < Cantidad() && pos > 1)
            {
                Nodo nodoAnterior = BuscarAnteriorPosN(pos);
                Nodo nodoAux = nodoAnterior.Siguiente;

                nodoAnterior.Siguiente = nodoAux.Siguiente;

                nodoAux.Siguiente = null;

                nodo = nodoAux;
            }


            return nodo;
            

        }
    }
}
