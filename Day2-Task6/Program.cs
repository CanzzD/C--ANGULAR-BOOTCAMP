using System;

namespace Day2Task6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Aşağıda class içerisinde belirttiğmiz özelliklerin karşılarına değerlerini ne ifade ettiklerini yazdık
            Products product1 = new Products();
            product1.ProductName = "Adidas Vs Pace Beyaz Ayakkabı";
            product1.Price = 879;
            product1.Seller = "Adidas";
            product1.Color = "Beyaz";

            Products product2 = new Products();
            product2.ProductName = "Apple Macbook Air M2";
            product2.Price = 25.599;
            product2.Seller = "Apple Store";
            product2.Color = "Uzay Gri";

            Products product3 = new Products();
            product3.ProductName = "LG 139 Ekran 4K TV";
            product3.Price = 16.199;
            product3.Seller = "LG";
            product3.Color = "Siyah";

            //Ürünleri kolay listeleyebilmek için bir dizi içerisine koyduk.
            Products[] products = new Products[] { product1, product2, product3 };

            Console.WriteLine("FOREACH DÖNGÜSÜ");
            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı :" + " " +  product.ProductName + " -- " + "Fiyat :" + " " + product.Price + " -- " + "Satıcı :" + " " + product.Seller + " -- " + "Renk : " + product.Color);
            }

            Console.WriteLine("FOR DÖNGÜSÜ");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı :" + " " + products[i].ProductName + "--" + "Fiyat :" + " " + products[i].Price + "--" + "Satıcı :" + " " + products[i].Seller);
            }

            Console.WriteLine("WHILE DÖNGÜSÜ");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine("Ürün Adı :" + " " + products[a].ProductName + "--" + "Fiyat :" + " " + products[a].Price + "--" + "Satıcı :" + " " + products[a].Seller);
                a++;
            }
        }

        //Bir class tanımladık ve ürünümüzün özelliklerini ve değişken tiplerini class içerisinde belirttik.
        class Products
        {
            public string ProductName { get; set; }
            public double Price { get; set; }
            public string Seller { get; set; }
            public string Color { get; set; }
        }
    }
}
