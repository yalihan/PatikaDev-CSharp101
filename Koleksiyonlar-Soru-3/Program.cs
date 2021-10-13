using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = Console.ReadLine();
            string sesliler = "aeıioöuü";

            ArrayList seslilerim = new ArrayList();

            for (int i = 0; i < cumle.Length; i++)
            {
                if (sesliler.Contains(cumle[i]))
                {
                    seslilerim.Add(cumle[i]);
                }
            }
            seslilerim.Sort();
            foreach (var sesli in seslilerim)
                Console.Write(sesli + "  ");
        }
    }
}
