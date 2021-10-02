using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soru4();
        }

        static void Soru1()
        {
            /*
                Kullanıcıdan pozitif bir sayı girmesini isteyin(n).
                Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
                Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            */
            Console.Write("Lütfen kaç tane sayı girmek istediğinizi giriniz : ");
            int girilenSayi = Int32.Parse(Console.ReadLine());
            
            int[] sayilar = new int[girilenSayi];
            for (int i = 0; i < girilenSayi; i++)
            {
                Console.Write("Lütfen {0}. sayiyi giriniz : ", i + 1);
                sayilar[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] % 2 == 0)
                    Console.WriteLine("Girmiş olduğunuz {0}. sayi = {1} sayısıdır ve çifttir.", i + 1, sayilar[i]);
            }
        }
        static void Soru2()
        {
            /*
                Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
                Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
                Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            */

            Console.Write("Lütfen kaç tane sayı girmek istediğinizi giriniz : ");
            int n = Int32.Parse(Console.ReadLine());
            int[] sayilar = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayiyi giriniz : ", i + 1);
                sayilar[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Girmiş olduğunuz sayılardan, hangi sayıya eşit yada tam bölünenleri görmek istersiniz : ");
            int m = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] == m)
                {
                    Console.WriteLine("Girmiş olduğunuz {0}. sayi = {1} sayısıdır ve {2} sayısına eşittir", i + 1, sayilar[i], m);
                }
                else if (sayilar[i]%m == 0)
                {
                    Console.WriteLine("Girmiş olduğunuz {0}. sayi = {1} sayısıdır ve {2} sayısına tam bölünür", i + 1, sayilar[i], m);
                }
            }
        }
        static void Soru3()
        {
            /*
                Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
                Sonrasında kullanıcıdan n adet kelime girmesini isteyin.
                Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            */
            Console.Write("Lütfen kaç tane kelime girmek istediğinizi giriniz : ");
            int n = Int32.Parse(Console.ReadLine());
            string[] kelimeler = new string[n];
            for (int i = 0; i < kelimeler.Length; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz : ", i + 1);
                kelimeler[i] = Console.ReadLine();
            }
            for(int i = kelimeler.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(kelimeler[i]);
            }

        }
        static void Soru4()
        {
            /*
                Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
                Cümledeki toplam kelime ve harf sayısını console'a yazdırın. 
            */
            Console.Write("Lütfen bir cümle giriniz : ");
            string cumlem = Console.ReadLine();

            string[] kelimelerim = cumlem.Split(" ");
            string bosluksuzCumlem = string.Join("", kelimelerim);

            Console.WriteLine("Cümlenizdeki kelime sayısı = " + kelimelerim.Length);
            Console.WriteLine("Cümlenizdeki harf sayısı = " + bosluksuzCumlem.Length);
        }
    }
}
