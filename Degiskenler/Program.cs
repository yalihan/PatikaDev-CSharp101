using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Veri tipleri kaç tane değer alır ?
             
             --> Tam Sayılar

             * bool    -->     00 Byte     =   01 Bit  =   2^01    =                                         2 tane değer alır
             * byte    -->     01 Byte     =   08 Bit  =   2^08    =                                       256 tane değer alır
             * short   -->     02 Byte     =   16 Bit  =   2^16    =                                    65.536 tane değer alır
             * int     -->     04 Byte     =   32 Bit  =   2^32    =                             4.294.967.296 tane değer alır
             * long    -->     08 Byte     =   64 Bit  =   2^64    =                18.446.744.073.709.551.616 tane değer alır
             
             --> Reel Sayılar

             * float   -->     04 Byte     =   32 Bit  =   2^32    =                             4.294.967.296 tane değer alır
             * double  -->     08 Byte     =   64 Bit  =   2^64    =                18.446.744.073.709.551.616 tane değer alır
             * decimal -->     12 Byte     =   96 Bit  =   2^96    =    79.228.162.514.264.337.593.543.950.336 tane değer alır
             
            */

            /* Kaç tane değer aldıklarını gördük. Bu değerler hangi değerler ?
             
             * Başında unsigned(işaretsiz) anlamına gelen 'u' olmayanlar; Aldıkları değer sayısının yarısını sıfırdan küçük, yarısını da sıfırdan büyük alırlar.
             * Başında unsigned(işaretsiz) anlamına gelen 'u' olanlar;    Aldıkları değer sayısının tamamını da sıfırdan büyük alırlar.
             * byte için --> başında signed(işaretli) anlamına gelen 's' varsa sıfırdan önce ve sonra bölüşür, yoksa hepsini sıfırdan büyük alır.
             
             --> Sadece pozitif değerleri alabilenler

             *                          0 <=   bool    <=   1
             *                          
             *                          0 <=   byte    <=   255
             *                          0 <=   ushort  <=   65.535
             *                          0 <=   uint    <=   4.294.967.295
             *                          0 <=   ulong   <=   18.446.744.073.709.551.616
             
             --> Negatif değerleri de pozitif değerleri de alabilenler

             *                       -128 <=   sbyte   <=   127          
             *                    -32.768 <=   short   <=   32.767
             *             -2.147.483.648 <=   int     <=   2.147.483.647
             * -9.223.372.036.854.775.808 <=   long    <=   9.223.372.036.854.775.807
            
            */

            bool        enKucukBool         =   false;
            bool        enBuyukBool         =   true;
                
            byte        enKucukByte         =   0;
            byte        enBuyukByte         =   255;

            
            short       enKucukShort        =  -32768;
            short       enBuyukShort        =   32767;

            ushort      enKucukUShort       =   0;    
            ushort      enBuyukUShort       =   65535;

            
            int         enKucukInt          =  -2147483648;
            int         enBuyukInt          =   2147483647;

            uint        enKucukUInt         =   0;
            uint        enBuyukUInt         =   4294967295;

            long        enKucukLong         =  -9223372036854775808;
            long        enBuyukLong         =   9223372036854775807;

            ulong       enKucukULong        =   0;
            ulong       enBuyukULong        =   18446744073709551615;


            // Datetime ın property(özellik) ve fonksiyonlarına yakından bakmak için:

            // https://docs.microsoft.com/tr-tr/dotnet/api/system.datetime?view=netcore-3.1

            // String kütüphanesinin fonksiyonlarına yakından bakmak için :

            // https://docs.microsoft.com/tr-tr/dotnet/api/system.string?view=netcore-3.1

        }
    }
}
