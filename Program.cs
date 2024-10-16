using System;


namespace Patika
{
    class Program{

        static void Main(string[] args)
        {
            byte b = 5;  //1byte
            sbyte c = 5; //1byte

            short s = 5;    //2 byte
            ushort us = 5;  //2 byte

            Int16 int16= 2; //2 byte
            int i = 2;      //4 byte
            Int32 int32 = 3;  //4 byte
            Int64 int64 = 4;  //8 byte
            uint ui = 2;      //4 byte

            long l = 4;      //8 byte
            ulong ul = 4;    //8 byte

            // real sayılar
            float fl = 4;    //4 byte
            double d = 4;   //8 byte
            decimal dc = 2;  //16 byte

            char cr = 'c';   //2 byte
            string st = "Süreyya";   //sınırsız

            bool t = true;
            bool f = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            string str = String.Empty;
            string str1 = null;
            str1 = "Merhaba";
            string ad = "Süreyya";
            string soyad = "Kadirova";
            string tamisim = ad + "" + soyad;

            int integer1= 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            bool b1 = 10 < 2;
            bool b2 = 10 > 2;

            //Değiişken dönüşümleri
            string str5 = "20";
            int i20 = 20;
            string yenideger = str5 + i20.ToString();
            Console.WriteLine(yenideger);





        }

    }
}



