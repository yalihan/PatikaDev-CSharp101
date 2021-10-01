using System;

namespace TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("*** Implicit Conversion ***\n");

            byte byteIC = 5;
            sbyte sByteIC = 30;
            short shortIC = 10;

            int intIC = byteIC + sByteIC + shortIC;
            Console.WriteLine("tipInt : " + intIC);

            long longIC = intIC;
            Console.WriteLine("tipLong : " + longIC);

            float floatIC = longIC;
            Console.WriteLine("tipFloat : " + floatIC);

            string stringIC = "Alihan";
            char charIC = 'Y';

            object tipObject = stringIC + charIC + intIC;
            Console.WriteLine("tipObject : " + tipObject);

            // Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("\n\n\n*** Explicit Conversion ***\n");

            int intEC = 4;
            byte intToByte = (byte)intEC;
            Console.WriteLine("byteTip : " + intToByte);

            int intEC2 = 100;
            byte intToByte2 = (byte)intEC2;
            Console.WriteLine("byteTip2 : " + intToByte2);

            float floatEC = 10.3f;
            byte floatToByte = (byte)floatEC;
            Console.WriteLine("byteTipFloat : " + floatToByte);

            // ToString Methodu
            Console.WriteLine("\n\n\n*** ToString Methodu ***\n");
            
            int intTS = 6;
            string intToString = intTS.ToString();
            Console.WriteLine("intToString : " + intToString);

            string floatToString = 12.5f.ToString();
            Console.WriteLine("tipStringToString : " + floatToString);

            // System.Convert
            Console.WriteLine("\n\n\n*** System.Convert ***\n");

            string stringSC = "10", stringSC2 = "20";
            int intSC, intSC2;
            int toplamSC;

            intSC = Convert.ToInt32(stringSC);
            intSC2 = Convert.ToInt32(stringSC2);

            toplamSC = intSC + intSC2;
            Console.WriteLine("toplamSystemConvert : " + toplamSC);

            // Parse
            Console.WriteLine("\n\n\n*** Parse ***\n");

            string stringP = "10";
            string stringP2 = "10.25";
            int intP;
            double doubleP;

            intP = Int32.Parse(stringP);
            doubleP = double.Parse(stringP2);
            Console.WriteLine("intP : " + intP);
            Console.WriteLine("doubleP : " + doubleP);
        }
    }
}