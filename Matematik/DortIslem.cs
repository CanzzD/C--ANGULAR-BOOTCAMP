using System;
namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 / sayi3;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
