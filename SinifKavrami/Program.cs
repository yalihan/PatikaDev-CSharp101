using System;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                                Söz Dizimi
                ------------------------------------------
                
                class SinifAdi
                {
                    ErişimBelirleyici VeriTipi ÖzellikAdi;
                    ErişimBelirleyici GeriDönüşTipi MetotAdi(ParametreListesi)
                    {
                        MetotKomutları
                    }
                }
            
            */
            /*
                            Erişim Belirleyicileri
                ---------------------------------------------
                * Public
                * Private
                * Internal
                * Protected
             */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Alihan";
            calisan1.Soyad = "Yılmaz";
            calisan1.No = 20525017;
            calisan1.Departman = "Matematik";
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Merve";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 20525018;
            calisan2.Departman = "Elt";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}
