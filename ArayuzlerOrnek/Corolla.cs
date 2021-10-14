using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzlerOrnek
{
    public class Corolla : Otomobil
    {
        public override Marka Markasi()
        {
            return Marka.Toyota;
        }
    }
}
