using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzlerOrnek
{
    public class Civic : Otomobil
    {
        public override Marka Markasi()
        {
            return Marka.Honda;
        }
        public override Renk Rengi()
        {
            return Renk.Gri;
        }
    }
}
