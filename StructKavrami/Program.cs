using System;

namespace StructKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdörtgen dikdörtgen1 = new Dikdörtgen();
            Console.WriteLine("Class Alan Hesabı: {0}",dikdörtgen1.AlanHesapla());

            Dikdörtgen dikdörtgen2 = new Dikdörtgen(4,5);
            Console.WriteLine("Class Alan Hesabı: {0}", dikdörtgen2.AlanHesapla());

            Dikdörtgen dikdörtgen3 = new Dikdörtgen();
            dikdörtgen3.KisaKenar = 3;
            dikdörtgen3.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}", dikdörtgen3.AlanHesapla());

            /*Dikdörtgen dikdörtgen4;
            dikdörtgen4.KisaKenar = 3;
            dikdörtgen4.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}", dikdörtgen4.AlanHesapla());*/



            StructDikdörtgen structDikdörtgen1 = new StructDikdörtgen();
            Console.WriteLine("Struct Alan Hesabı: {0}", structDikdörtgen1.AlanHesapla());

            StructDikdörtgen structDikdörtgen2 = new StructDikdörtgen(6,7);
            Console.WriteLine("Struct Alan Hesabı: {0}",structDikdörtgen2.AlanHesapla());

            StructDikdörtgen structDikdörtgen3 = new StructDikdörtgen();
            structDikdörtgen3.KisaKenar = 3;
            structDikdörtgen3.UzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabı: {0}", structDikdörtgen3.AlanHesapla());

            StructDikdörtgen structDikdörtgen4;
            structDikdörtgen4.KisaKenar = 3;
            structDikdörtgen4.UzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabı: {0}", structDikdörtgen4.AlanHesapla());
        }
    }
    class Dikdörtgen    //referans tiplidirler
    {
        public int KisaKenar;
        public int UzunKenar;

        public Dikdörtgen()      //boş constructor olabiliyor
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public Dikdörtgen(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
    struct StructDikdörtgen //değer tiplidirler     ,   diğer struct yada sınıflardan kalıtım alamazlar ancak interfaceden alabilirler
    {
        public int KisaKenar;
        public int UzunKenar;

        /*public Dikdörtgen()      //boş constructor olamıyor
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }*/
        public StructDikdörtgen(int kisaKenar, int uzunKenar)
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        
        public long AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}
