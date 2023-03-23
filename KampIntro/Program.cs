using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //ctrl+alt+i "" çift tırnak işareti

            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarBugun == dolarDun)
            {
                Console.WriteLine("Değişmemiş");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Giriş Yapmış");
            }
            else
            {
                Console.WriteLine("Giriş Yapmamış");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
