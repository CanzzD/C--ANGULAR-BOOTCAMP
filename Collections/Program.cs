using System;
using System.Collections.Generic;

namespace Collections
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string[] isimler = new string[] {"can","ali","mehmet" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[4];
            //isimler[3] = "selma";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[0]);

            //BİR DİZİ OLUŞTURDUĞUMUZ ZAMAN O DİZİYE YENİ ELEMAN EKLEMEK İSTERSEK
            //ÖNCEKİ ELEMANLARI KAYBEDERİZ.LİST YAPISI BİZE YENİ ELEMAN EKLEME VE DİĞER FONKSİYONLARI SUNAR.

            List<string> isimler2 = new List<string> { "can", "ali", "mehmet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
