using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Pila
    {
        Lista lista;

        public Pila()
        {
            lista = new Lista();
        }

        public void Apilar(Nodo pNodo)
        {
            lista.AgregarPrimero(pNodo);
        }
        public Nodo Desapilar()
        {
            return lista.BorrarPrimero();
        }
    }
}
