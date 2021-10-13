using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int index = 0;
            int input = 0;
            bool isExistError;

            while (index < numbers.Length)
            {
                isExistError = false;
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    isExistError = true;
                }
                finally
                {
                    if (isExistError)
                        Console.WriteLine("Sadece sayı giriniz!");
                    else
                    {
                        numbers[index] = input;
                        index++;
                    }
                }
            }
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            
            Console.WriteLine("***** Girdiğiniz Sayılar *****\n\n");

            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
                Console.Write(number + "\t");
            }
            double ort = sum / numbers.Length;
            Console.WriteLine("\n\nGirdiklerinizin Sayısı : " + numbers.Length);
            Console.WriteLine("Girdiklerinizin Toplamı : " + sum);
            Console.WriteLine("Girdiklerinizin Ortalaması : " + ort);



            Console.WriteLine("\n\n\n***** En küçük 3 eleman *****\n\n");

            Array.Sort(numbers);
            int[] minItems = new int[3];
            int minSum = 0;
            for (int i = 0; i < minItems.Length; i++)
            {
                minItems[i] = numbers[i];
                Console.Write(minItems[i] + "\t");
                minSum += minItems[i];
            }
            double minOrt = minSum / minItems.Length;
            Console.WriteLine("\nEn Küçük 3 Eleman Toplamı : " + minSum);
            Console.WriteLine("En Küçük 3 Eleman Ortalaması : " + minOrt);



            Console.WriteLine("\n\n\n***** En Büyük 3 Eleman *****\n\n");

            Array.Reverse(numbers);
            int[] maxItems = new int[3];
            int maxSum = 0;
            for (int i = 0; i < maxItems.Length; i++)
            {
                maxItems[i] = numbers[i];
                Console.Write(maxItems[i] + "\t");
                maxSum += maxItems[i];
            }
            int maxOrt = maxSum / maxItems.Length;
            Console.WriteLine("\nEn Büyük 3 Eleman Toplamı : " + maxSum);
            Console.WriteLine("En Büyük 3 Eleman Ortalaması : " + maxOrt);

            double sumOrt = minOrt + maxOrt;
            Console.WriteLine("\n\n\nOrtalamalar Toplamı : " + sumOrt);
        }
    }
}
