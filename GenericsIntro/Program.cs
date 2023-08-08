using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Can");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);

            
        }
    }
}
