using System;
namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        
        ////Void sadece emir alır git sayı1 ve sayı 2 yi topla gibi
        //public void Topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2); 
        //}

        ////Ancak biz yaptığımız işlemi devamında kullanmak istyorsak return e ihtiyacımız vardır metotda void kullanmayız.
        //public int Topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
    }
}
