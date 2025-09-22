using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NodoGenerico;

namespace Ej16ColaSuperMercado
{
    internal class ColaClientes
    {
        private Nodo<Cliente> centinela;

        public ColaClientes() {
            centinela = new Nodo<Cliente>();
        }

        public Nodo<Cliente> Desencolar()
        {
            Nodo<Cliente> nodoAux = null;

            if (centinela.Siguiente != null) {

                nodoAux = centinela.Siguiente;
                centinela.Siguiente = nodoAux.Siguiente;
                nodoAux.Siguiente = null;
            }

            return nodoAux;
            
        }

        public void Encolar(Nodo<Cliente> pNodo) {


            if (centinela.Siguiente == null)
            {
                centinela.Siguiente = pNodo.CloneTipado();
            }
            else
            {
                BuscarUltimoRecursivo(centinela.Siguiente).Siguiente = pNodo.CloneTipado();
            }

        }

        private Nodo<Cliente> BuscarUltimoRecursivo(Nodo<Cliente> pNodo)
        {
            if (pNodo.Siguiente != null)
            {
                pNodo = BuscarUltimoRecursivo(pNodo.Siguiente);
            }
            return pNodo;
        }

        public int PorCobrar() {
            return CalcularPorCobrarRecursivo(centinela.Siguiente, 0);
        }

        private int CalcularPorCobrarRecursivo(Nodo<Cliente> pNodo, int total) 
        {
            if (pNodo != null)
            {
                total = CalcularPorCobrarRecursivo(pNodo.Siguiente, total + pNodo.Contenido.Importe);
            }
            return total;
        }

        public int Largo()
        {
            return CalcularLargoRecursivo(centinela, 0);
        }

        public int CalcularLargoRecursivo(Nodo<Cliente> pNodo, int l)
        {
            if (pNodo.Siguiente != null)
            {
                l = CalcularLargoRecursivo(pNodo.Siguiente, l+1);
            }
            return l;
        }
    }
}
