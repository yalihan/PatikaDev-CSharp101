using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArayuzlerOrnek
{
    public class Focus : Otomobil
    {
        public override Marka Markasi()
        {
            return Marka.Ford;
        }
    }
}
