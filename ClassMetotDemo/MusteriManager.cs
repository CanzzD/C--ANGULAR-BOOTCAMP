using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Başarıyla Eklendi:" + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Bakiye);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Kalan Müşteriler");

            Musteri[] musteriler = new Musteri[] { musteri };

            foreach (Musteri musteriA in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine("--------------");
            }

        }
        public void MusteriListele(Musteri musteri)
        {

            Console.WriteLine("Müşteriler Listeleniyor");


            Musteri[] musteriler = new Musteri[] {musteri };

            foreach (Musteri musteriA in musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine("--------------");
            }
        }
    }
}
