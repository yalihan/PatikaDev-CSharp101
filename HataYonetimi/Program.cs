using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            bool hatamVarmi = false;
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception benimHatam)
            {
                hatamVarmi = true;
                Console.WriteLine("Hata : " + benimHatam.Message.ToString());
            }
            finally
            {
                if (hatamVarmi)
                    Console.WriteLine("Kod hatalı çalıştı");
                else
                    Console.WriteLine("Kod hatasız çalıştı");
            }
            */

            Console.WriteLine("\n\n\n***Tipe bağlı catching***\n");
            try
            {
                //int nullException = int.Parse(null);
                //int formatException = int.Parse("test");
                int overFlowExcepiton = int.Parse("20000000000");
            }
            catch (ArgumentNullException benimNullHatam)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(benimNullHatam);
            }
            catch (FormatException benimFormatHatam)
            {
                Console.WriteLine("Veri tipi uygun değil!");
                Console.WriteLine(benimFormatHatam);
            }
            catch (OverflowException benimOverFlowHatam)
            {
                Console.WriteLine("Çok küçük ada çok büyük bir değer girdiniz!");
                Console.WriteLine(benimOverFlowHatam);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Sonuçlandı :)");
            }
        }
    }
}
