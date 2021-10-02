using System;

namespace MetotlarOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out parametreler
            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlarim instance = new Metotlarim();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            // Metot Aşırı Yükleme - Overloading
            int intIfade = 999;
            string stringIfade = "ali";
            instance.EkranaYazdir(stringIfade);
            instance.EkranaYazdir(intIfade);

            /*
             --> Metot Imzası = MetotAdı + parametre sayısı + parametre tipi
             
            bu üçünden biri farklı olursa metot imzası farklılaşmış olur
            
             */

        }
    }
    class Metotlarim
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }
    }
}
