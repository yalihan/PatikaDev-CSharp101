using System;

namespace RecursiveExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinelemeli fonksiyonlar
            // --> 3^4 ün hesaplaması

            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // Extension Metotlar
            string ifade = "Alihan Yılmaz Ytü";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = {3, 5, 9, 8, 4, 18, 24, 13, 0};
            dizi.EkranaDiziYazdir();
            dizi.DiziSirala();
            dizi.EkranaDiziYazdir();
        }
    }
    public class Islemler
    {
        public int Expo(int sayi,int üs)
        {
            if (üs < 2)
            {
                return sayi;
            }
            else
            {
                return Expo(sayi,üs-1)*sayi;
            }
        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }
        public static int[] DiziSirala(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaDiziYazdir(this int[] param)
        {
            foreach(var eleman in param)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }
    }
}