using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16ColaSuperMercado
{
    internal class Cliente : ICloneable
    {
        public int Id { get; set; }
        public int Importe { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
