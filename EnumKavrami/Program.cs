using System;

namespace EnumKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.ÇokSoğuk)
                Console.WriteLine("Hava Çok Soğuk");
            else if (sicaklik <= (int)HavaDurumu.Soğuk)
                Console.WriteLine("Hava Soğuk");
            else if (sicaklik <= (int)HavaDurumu.Normal)
                Console.WriteLine("Hava Normal");
            else if (sicaklik <= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Hava Sıcak");
            else if (sicaklik <= (int)HavaDurumu.ÇokSıcak)
                Console.WriteLine("Hava Çok Sıcak");
            else
                Console.WriteLine("Yanıyoz");
        }
    }
    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        ÇokSoğuk = 10,
        Soğuk = 15,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30,
    }
}
