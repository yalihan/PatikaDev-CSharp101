using System;

namespace DongulerWhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            // While
            //  --> 1 den, consoledan girilen sayıya kadar(dahil) ortalama hesaplayıp console a yazdıran program.
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("*** 1 den, consoledan girilen sayıya kadar(dahil) ortalama ***");
            Console.WriteLine("--------------------------------------------\n");

            Console.Write("Bir sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;

            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            double ort = toplam / sayi;
            Console.WriteLine("Ortalama = " + ort);



            // --> 'a' dan 'z' ye kadar tüm harfleri console a yazdır
            Console.WriteLine("\n\n\n--------------------------------------------");
            Console.WriteLine("*** a dan z ye olan harfler ***");
            Console.WriteLine("--------------------------------------------\n");

            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }



            // foreach
            Console.WriteLine("\n\n\n--------------------------------------------");
            Console.WriteLine("*** Foreach ***");
            Console.WriteLine("--------------------------------------------\n");

            string[] arabalar = {"Ford","Toyota","Nissan"};

            foreach(var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
