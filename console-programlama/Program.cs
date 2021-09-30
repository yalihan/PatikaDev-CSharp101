using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi Giriniz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz: ");
            string surName = Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz " + name + " " + surName);
        }
    }
}
