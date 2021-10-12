using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Collection.Generic
            Dictionary<int, string> users = new Dictionary<int, string>();
            users.Add(26,"Alihan Yılmaz");
            users.Add(25, "Merve Yılmaz");
            users.Add(4, "Afra Zeyneb Yılmaz");
            users.Add(3, "Ömer Hamza Yılmaz");

            // Dizinin elemanlarına erişim
            Console.WriteLine(users[25]);
            foreach (var user in users)
                Console.WriteLine(user);

            // Count
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Ömer Hamza"));
            Console.WriteLine(users.ContainsValue("Afra Zeyneb"));

            // Remove
            users.Remove(3);
            foreach (var user in users)
                Console.WriteLine(user);

            // Keys
            foreach (var user in users.Keys)
                Console.WriteLine(user);

            // Values
            foreach (var user in users.Values)
                Console.WriteLine(user);

        }
    }
}
