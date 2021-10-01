using System;

namespace IfElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int simdikiZaman = DateTime.Now.Hour;
            Console.WriteLine(simdikiZaman);

            string sonuc;
            if (simdikiZaman >= 6 && simdikiZaman < 11)
                sonuc = "Günaydın";
            else if (simdikiZaman < 18)
                sonuc = "İyi Günler";
            else
                sonuc = "İyi Akşamlar";

            string sonucTernary;

            sonucTernary =
                simdikiZaman < 11 ? "Günaydın" : 
                simdikiZaman <= 18 ? "İyi Günler" : "İyi Akşamlar";

            Console.WriteLine("Normal ifElse ifadesinin sonucu : " + sonuc);
            Console.WriteLine("Ternary ifadesinin sonucu : " + sonucTernary);
        }
    }
}
