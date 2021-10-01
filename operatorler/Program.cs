using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama
            Console.WriteLine("*** Atama ve İşlemli Atama ***\n");

            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal Operatörler --> || , && , !
            Console.WriteLine("\n\n\n*** Mantıksal Operatörler --> || , && , ! ***\n");

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("İkisi beraber doğru ise");
            if (isSuccess || isCompleted)
                Console.WriteLine("İkisinden biri doğru ise");
            if (isSuccess && !isCompleted)
                Console.WriteLine("isSuccess doğru ve isCompleted yanlış ise");
            if (isSuccess || !isCompleted)
                Console.WriteLine("isSuccess doğru veya isCompleted yanlış ise");

            // İlişkisel Operatörler --> == , < , > , <= , >= , !=
            Console.WriteLine("\n\n\n*** İlişkisel Operatörler --> == , < , > , <= , >= , != ***\n");
            int a = 3;
            int b = 4;
            bool iliskiselSonuc = a < b;

            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a > b;
            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a >= b;
            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a < b;
            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a <= b;
            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a == b;
            Console.WriteLine(iliskiselSonuc);
            iliskiselSonuc = a != b;
            Console.WriteLine(iliskiselSonuc);
            
            // Aritmetik Operatörler --> + , - , * , / , ++(bir artırır) , --(bir eksiltir) , %(mod alır)
            Console.WriteLine("\n\n\n*** Aritmetik Operatörler --> + , - , * , / , ++(bir artırır) , --(bir eksiltir) , %(mod alır) ***\n");

            int k = 10;
            int l = 5;
            int aritmetikSonuc = k + l;
            Console.WriteLine(aritmetikSonuc);
            aritmetikSonuc = k / l;
            Console.WriteLine(aritmetikSonuc);
            aritmetikSonuc = k * l;
            Console.WriteLine(aritmetikSonuc);
            aritmetikSonuc = k++;
            Console.WriteLine(aritmetikSonuc);
            aritmetikSonuc = 20 % 3;
            Console.WriteLine(aritmetikSonuc);
        }
    }
}
