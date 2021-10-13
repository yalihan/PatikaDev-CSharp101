using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Alihan";
            ogrenci1.SoyIsim = "Yılmaz";
            ogrenci1.OgrenciNo = 20525017;
            ogrenci1.Sinif = 2;
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();

            ogrenci1.OgrenciBilgileriniGetir();
        }
    }
    class Ogrenci
    {
        private string isim;
        private string soyIsim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        { 
            get => sinif;

            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("Öğrenci Adı: {0}", Isim);
            Console.WriteLine("Öğrenci Soyadı: {0}", SoyIsim);
            Console.WriteLine("Öğrenci Numarası: {0}", OgrenciNo);
            Console.WriteLine("Öğrenci Sınıf: {0}", Sinif);
        }

        public void SinifAtlat()
        {
            Sinif++;
        }
        public void SinifDusur()
        {
            Sinif--;
        }
    }
}
