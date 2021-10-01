using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminiz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminiz: ");
            string surName = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz " + name + " " + surName);
        }
    }
}
