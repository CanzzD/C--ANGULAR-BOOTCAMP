using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public List<Musteri> _musteriler;

        public MusteriManager()
        {
            _musteriler = new List<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            _musteriler.Add(musteri);
            Console.WriteLine("Müşteri Başarıyla Eklendi:" + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Bakiye);
        }
        public void MusteriSil(Musteri musteri)
        {
            _musteriler.Remove(musteri);
            Console.WriteLine("Kalan Müşteriler");

            foreach (Musteri musteriA in _musteriler)
            {
                Console.WriteLine(musteriA.Ad);
                Console.WriteLine(musteriA.Soyad);
                Console.WriteLine(musteriA.Bakiye);
                Console.WriteLine("--------------");
            }

        }

        public void MusteriListele()
        {
            foreach (var musteri in _musteriler)
            {
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine("-----------");
            }
        }
    }
}
