using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Veri tipleri kaç tane değer alır ?
             
             * bool    -->     00 Byte     =   01 Bit  =   2^01    =                            2 tane değer alır
             * byte    -->     01 Byte     =   08 Bit  =   2^08    =                          256 tane değer alır
             * short   -->     02 Byte     =   16 Bit  =   2^16    =                       65.536 tane değer alır
             * int     -->     04 Byte     =   32 Bit  =   2^32    =                4.294.967.296 tane değer alır
             * long    -->     08 Byte     =   64 Bit  =   2^64    =   18.446.744.073.709.551.616 tane değer alır
             
            */

            /* Veri tipleri hangi değerleri alır ? 
             
             * Başında unsigned(işaretsiz) anlamına gelen 'u' olmayanlar; Aldıkları değer sayısının yarısını sıfırdan küçük, yarısını da sıfırdan büyük alırlar.
             * Başında unsigned(işaretsiz) anlamına gelen 'u' olanlar;    Aldıkları değer sayısının tamamını da sıfırdan büyük alırlar.
             * byte, başında signed(işaretli) anlamına gelen 's' varsa sıfırdan önce ve sonra bölüşür, yoksa hepsini sıfırdan büyük alır.

             *              0 <=   bool    <=               1
             *              
             *              0 <=   byte    <=             255
             *              0 <=   ushort  <=          65.535
             *              0 <=   uint    <=   4.294.967.295
             * 
             *           -128 <=   sbyte   <=   127          
             *        -32.768 <=   short   <=   32.767
             * -2.147.483.648 <=   int     <=   2.147.483.647
            
            */

            bool        enKucukBool         =  false;
            bool        enBuyukBool         =  true;
                
            byte        enKucukByte         =  0;
            byte        enBuyukByte         =  255;

            
            short       enKucukShort        = -32768;
            short       enBuyukShort        =  32767;

            ushort      enKucukUShort       =  0;    
            ushort      enBuyukUShort       =  65535;

            
            int         enKucukInt          = -2147483648;
            int         enBuyukInt          =  2147483647;

            uint        enKucukUInt         =  0;
            uint        enBuyukUInt         =  4294967295;
        }
    }
}
