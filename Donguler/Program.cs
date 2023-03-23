using System;

namespace Donguler
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kampı";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //aray - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlamaya Başlangıç İçin Temel Kurs", "Java Kampı", "Flutter Kampı"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
