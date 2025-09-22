using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodoGenerico
{
    public class Nodo<T> : ICloneable where T : class, ICloneable
    {

        public T? Contenido { get; set; }
        public Nodo<T>? Siguiente { get; set; }

        public Nodo<T>? Anterior { get; set; }
        public Nodo(
            T? pContenido = null,
            Nodo<T>? pSiguiente = null,
            Nodo<T>? pAnterior = null
        ) {
            Contenido = pContenido;
            Siguiente = pSiguiente;
            Anterior = pAnterior;
        }

        public object Clone()
        {
            return new Nodo<T>(  (T)Contenido.Clone() , null, null );
        }

        public Nodo<T> CloneTipado()
        {
            return (Nodo<T>)this.Clone();
        }
    }
}
