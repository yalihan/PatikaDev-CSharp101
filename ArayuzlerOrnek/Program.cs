using System;

namespace ArayuzlerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.TekerlekSayisi());
            Console.WriteLine(focus.Markasi());
            Console.WriteLine(focus.Rengi());

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.TekerlekSayisi());
            Console.WriteLine(corolla.Markasi());
            Console.WriteLine(corolla.Rengi());

            Civic civic = new Civic();
            Console.WriteLine(civic.TekerlekSayisi());
            Console.WriteLine(civic.Markasi());
            Console.WriteLine(civic.Rengi());

            Otomobil otomobil = new Focus();
            Console.WriteLine(otomobil.TekerlekSayisi());
            Console.WriteLine(otomobil.Markasi());
            Console.WriteLine(otomobil.Rengi());
        }
    }
}
