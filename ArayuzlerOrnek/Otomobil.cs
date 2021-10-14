using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzlerOrnek
{
    public abstract class Otomobil
    {
        public int TekerlekSayisi()
        {
            return 4;
        }
        public virtual Renk Rengi()
        {
            return Renk.Beyaz;
        }
        public abstract Marka Markasi();
    }
}
