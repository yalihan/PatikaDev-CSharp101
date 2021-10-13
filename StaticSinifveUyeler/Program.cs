using System;

namespace StaticSinifveUyeler //static sınıflara kalıtım uygulanamaz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Başlangıçta ki Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1 = new Calisan("Alihan", "Yılmaz", "Matematik");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Merve", "Yılmaz", "Elt");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("\n\n\n*** İşlemler ***");

            Console.WriteLine("Toplama işlemi sonucu: {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu: {0}", Islemler.Cikar(100, 50));
        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()    // Sadece en başta çalışır
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            Departman = departman;
            calisanSayisi++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
