using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Nodo(string pDescriptor = "", int pNumero = -1, Nodo? pSiguiente = null) : ICloneable
    {
        public string Palo { get; set; } = pDescriptor;
        public int Numero { get; set; } = pNumero;
        public Nodo? Siguiente { get; set; } = pSiguiente;

        public object Clone()
        {
            Nodo nodo = (Nodo)MemberwiseClone();
            nodo.Siguiente = null;
            return nodo;
        }

        public Nodo CloneTipado() => (Nodo)Clone();
    }
}
