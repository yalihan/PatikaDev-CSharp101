using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ErişimBelirteci, geriDonusTipi, metotAdı(parametreler / argüman)
            {
                Komutlar
            }
            */
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
    
            Metotlarım ornek = new Metotlarım();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());

            Console.WriteLine(a.ToString());
        }

        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }

    class Metotlarım
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
