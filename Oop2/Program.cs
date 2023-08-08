using System;

namespace Oop2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Can Özdemir -- Gerçek müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Can";
            musteri1.Soyadi = "Özdemir";
            musteri1.TcNo = "12312312312";

            //Tüzel Müşteri
            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "54321";
            tuzelMusteri1.SirketAdi = "canAŞ";
            tuzelMusteri1.VergiNo = "454454531";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            /* MUSTERİ SINIFI DİĞER 2 SINIFIMIZ ÜST SINIFI OLDUĞU İÇİN
             VE KALITIM YAPTIĞI İÇİN İKİSİNİNDE REFERANS NOLARINI
            TUTABİLİYOR. BU DA DEMEK OLUYOR Kİ MUSTERİ SINIFINDA
            YAZDIĞIMIZ BİR FONKSİYONU HER İKİ SINIF ÜZERİNDE
            KULLANABİLİRİZ. */

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(tuzelMusteri1);

        }
    }
}
