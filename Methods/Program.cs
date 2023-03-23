using System;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 50;
            urun1.Satici = "Özdemir Manav";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 150;

            Urun urun3 = new Urun();
            urun3.Adi = "Sarımsak";
            urun3.Fiyati = 50;
            urun3.Aciklama = "Taşköprü Sarımsağı";
            urun3.StokAdedi = 20;

            Urun urun4 = new Urun();
            urun4.Adi = "Yerli Muz";
            urun4.Fiyati = 20;
            urun4.Aciklama = "Anamur Muzu";
            urun4.StokAdedi = 70;
            urun4.Satici = "Özdemir Manav";


            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4};

            foreach (Urun urun  in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Satici);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("-------------Metotlar------------");

            //instance - ornek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            sepetManager.Ekle(urun4);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 20 ,10);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 20, 9);
            sepetManager.Ekle2("Armut", "Yeşil Armut", 20, 7);
        }
    }
}

