using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList(20);
            int i = 0;
            int input = 0;
            bool isExistError;
           
            while (i < numbers.Count)
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
                    if (isExistError || input <= 0)
                        Console.WriteLine("Sadece pozitif sayı giriniz!");
                    else
                    {
                        numbers[i] = input;
                        i++;
                    }
                }
            }
            //ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();
            bool isPrime;

            foreach (int number in numbers)
            {
                isPrime = true;
                if (number == 1)
                    isPrime = false;
                else
                {
                    for (int j = 2; j < number; j++)
                    {
                        if (number % j == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                if (isPrime)
                    primeNumbers.Add(number);
                else
                    notPrimeNumbers.Add(number);
            }

            Console.WriteLine("***** Girdiğiniz Sayılar *****\n");
            
            int sum = 0;
            numbers.Sort();
            numbers.Reverse();

            foreach (int number in numbers)
            {
                sum += number;
                Console.Write(number + "\t");
            }

            Console.WriteLine("\n\nGirdiklerinizin sayısı : " + numbers.Count);
            Console.WriteLine("Girdiklerinizin toplamı : " + sum);
            Console.WriteLine("Girdiklerinizin ortalaması : " + sum / numbers.Count);



            Console.WriteLine("\n\n\n***** Asal Sayılar *****\n");
            
            int sumPrime = 0;
            primeNumbers.Sort();
            primeNumbers.Reverse();

            foreach(int number in primeNumbers)
            {
                sumPrime += number;
                Console.Write(number + "\t");
            }

            Console.WriteLine("\n\nAsal olanların sayısı : " + primeNumbers.Count);
            Console.WriteLine("Asal olanların toplamı : " + sumPrime);
            Console.WriteLine("Asal olanların ortalaması : " + sumPrime / primeNumbers.Count);
            


            Console.WriteLine("\n\n\n***** Asal Olmayan Sayılar *****\n");
            
            int sumNotPrime = 0;
            notPrimeNumbers.Sort();
            notPrimeNumbers.Reverse();

            foreach (int number in notPrimeNumbers)
            {
                sumNotPrime += number;
                Console.Write(number + "\t");
            }

            Console.WriteLine("\n\nAsal olmayanların sayısı : " + notPrimeNumbers.Count);
            Console.WriteLine("Asal olmayanların toplamı : " + sumNotPrime);
            Console.WriteLine("Asal olmayanların ortalaması : " + sumNotPrime / notPrimeNumbers.Count);
        }
    }
}
