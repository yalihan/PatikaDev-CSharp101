using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool        enKucukBool         =  false;
            bool        enBuyukBool         =  true;


            byte        enKucukByte         =  0;
            byte        enBuyukByte         =  255;

            
            short       enKucukShort        = -32768;
            short       enBuyukShort        =  32767;

            ushort      enKucukUShort       =  0;           // u demek unsigned demek. Yani işaretsiz.
            ushort      enBuyukUShort       =  65535;       // bu sebeple u olmayan veri tipinin eksilisini de artı tarafa ekliyor

            
            int         enKucukInt          = -2147483648;
            int         enBuyukInt          =  2147483647;

            uint        enKucukUInt         =  0;
            uint        enBuyukUInt         =  4294967295;
        }
    }
}
