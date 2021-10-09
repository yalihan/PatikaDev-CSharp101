using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collection.Generic
            // T --> objecct türündedir.

            List<int> sayiListesi = new List<int>();
            
            sayiListesi.Add(15);
            sayiListesi.Add(20);
            sayiListesi.Add(25);
            sayiListesi.Add(30);
            sayiListesi.Add(35);
            sayiListesi.Add(40);


            List<string> renkListesi = new List<string>();
            
            renkListesi.Add("Siyah");
            renkListesi.Add("Beyaz");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");


            // Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            // foreach ve List.Forreach ile elemanlara erişim
            foreach(var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Listeden eleman çıkarma

            // --> Elemana Göre
            sayiListesi.Remove(15);
            renkListesi.Remove("Siyah");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // --> Indexe Göre
            sayiListesi.RemoveAt(1);
            renkListesi.RemoveAt(2);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            // Liste Icerisinde Arama
            if (sayiListesi.Contains(36))
                Console.WriteLine("10 Liste içerisinde bulundu");
            else
                Console.WriteLine("10 Liste içerisinde bulunamadı");


            // Eleman ile Index'e Erişme
            Console.WriteLine(renkListesi.BinarySearch("Yeşil"));


            // Dizi'yi List'e Çevirme
            string[] hayvanlar = { "Kedi", "Köpek", "Kartal" };
            List<string> hayvanListesi = new List<string>(hayvanlar);


            // Listeyi Temizleme
            hayvanListesi.Clear();


            // List İçerisinde Nesne Tutmak
            List<Kullanicilar> kullaniciListesi1 = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Alihan";
            kullanici1.SoyIsım = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici1.Isim = "Merve";
            kullanici1.SoyIsım = "Yılmaz";
            kullanici1.Yas = 25;

            kullaniciListesi1.Add(kullanici1);
            kullaniciListesi1.Add(kullanici2);

            foreach (var kullanici in kullaniciListesi1)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanici.SoyIsım);
                Console.WriteLine("Kullanıcı Yaşı : " + kullanici.Yas);
            }


            List<Kullanicilar> kullaniciListesi2 = new List<Kullanicilar>();
            kullaniciListesi2.Add(
                new Kullanicilar() { Isim = "Ömer Hamza", SoyIsım = "Yılmaz", Yas = 3 }
            );
            kullaniciListesi2.Add(
                new Kullanicilar() { Isim = "Afra Hatun", SoyIsım = "Yılmaz", Yas = 4 }
            );

            foreach (var kullanici in kullaniciListesi2)
            {
                Console.WriteLine("Kullanıcı Adı : " + kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı : " + kullanici.SoyIsım);
                Console.WriteLine("Kullanıcı Yaşı : " + kullanici.Yas);
            }
        }
    }
    public class Kullanicilar
    {
        private string isim;
        private string soyIsim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsım { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
