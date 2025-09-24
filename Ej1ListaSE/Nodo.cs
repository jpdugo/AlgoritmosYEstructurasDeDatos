using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Ej1ListaSE
{
    internal class Nodo : ICloneable
    {
        public string Descriptor { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(string pDescriptor = "", Nodo pSiguiente = null)
        {
            Descriptor = pDescriptor;
            Siguiente = pSiguiente;
        }

        public object Clone()
        {
            Nodo nodo = (Nodo)this.MemberwiseClone();
            nodo.Siguiente = null;
            return nodo;
        }

        public Nodo CloneTipado() => (Nodo)this.Clone();
    }
}
