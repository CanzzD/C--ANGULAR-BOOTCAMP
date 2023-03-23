using System;
namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi +  "---"  + urun.StokAdedi);
        }

        public void Ekle2(string Adi, string Aciklamasi, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + Adi);
        }
    }
}
