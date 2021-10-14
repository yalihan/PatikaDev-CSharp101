using System;

namespace InheritenceKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                                     Canlılar
                                        |
                      Bitkiler                     Hayvanlar
                   |           |                |             |
                Tohumlu     Tohumsuz        Sürüngenler     Kuşlar
             */

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}
