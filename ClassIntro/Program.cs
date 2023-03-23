using System;

namespace ClassIntro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Yazılım Geliştirici Kampı";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Programlamaya Başlangıç İçin Temel Kurs";
            kurs2.Egitmen = "Can Özdemir";
            kurs2.IzlenmeOrani = 55;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java Kampı";
            kurs3.Egitmen = "Esma Göktaş";
            kurs3.IzlenmeOrani = 79;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            //Console.WriteLine(kurs2.KursAdi + " : " + kurs2.Egitmen);
            //Console.WriteLine(kurs3.KursAdi + " : " + kurs3.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen) ;
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
