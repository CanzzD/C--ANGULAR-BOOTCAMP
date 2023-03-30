using System;

namespace ClassMetotDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Atakan";
            musteri1.Soyad = "Yılmaz";
            musteri1.Bakiye = 50000;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Can";
            musteri2.Soyad = "Özdemir";
            musteri2.Bakiye = 100000;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Samet";
            musteri3.Soyad = "Aktaş";
            musteri3.Bakiye = 20000;


            MusteriManager musteriManager = new MusteriManager();


            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriListele();

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriSil(musteri3);




        }
    }
}
