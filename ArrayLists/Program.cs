using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collections namespace
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Alihan");
            arrayList.Add(26);
            arrayList.Add(true);
            arrayList.Add('M');



            // İçerisinde verilere erişim
            Console.WriteLine(arrayList[1]);
            foreach (var item in arrayList)
                Console.WriteLine(item);



            // AddRange
            string[] renkler = { "Kırmızı", "Beyaz", "Mavi" };
            List<int> sayilar = new List<int> { 1, 2, 3, 5, 8, 13 };
            arrayList.AddRange(renkler);
            arrayList.AddRange(sayilar);

            foreach (var item in arrayList)
                Console.WriteLine(item);



            // Sorting
            arrayList.Sort(); // sayi değerleri için



            // Binary Search
            Console.WriteLine(arrayList.BinarySearch(9));



            // Reverse
            arrayList.Reverse();
            foreach(var item in arrayList)
                Console.WriteLine(item);



            // Clear

            arrayList.Clear();
            foreach (var item in arrayList)
                Console.WriteLine(item);
        }
    }
}
