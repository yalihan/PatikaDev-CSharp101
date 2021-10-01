using System;

namespace DizilerArraySinifiMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            
            Console.WriteLine("*** Sırasız Dizi ***\n");
            
            foreach(var sayi in sayiDizisi)
                Console.Write(sayi + " ");

            Console.WriteLine("\n\n\n*** Sıralı Dizi ***\n");
            Array.Sort(sayiDizisi);
            
            foreach(var sayi in sayiDizisi)
                Console.Write(sayi + " ");

            // Clear
            Console.WriteLine("\n\n\n*** Array Clear ***\n");
            
            // SayiDizisi elemanlarını kullanarak, 2.index den itibaren 2 tane elemanı sıfırlar
            Array.Clear(sayiDizisi, 2, 2);
            
            foreach(var sayi in sayiDizisi)
                Console.Write(sayi + " ");

            // Reverse
            Console.WriteLine("\n\n\n*** Array Reverse ***\n");
            Array.Reverse(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
                Console.Write(sayi + " ");

            // IndexOf
            Console.WriteLine("\n\n\n*** Array IndexOf ***\n");

            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            // Resize
            Console.WriteLine("\n\n\n*** Array Resize ***\n");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach(var sayi in sayiDizisi)
                Console.Write(sayi + " ");
        }
    }
}
