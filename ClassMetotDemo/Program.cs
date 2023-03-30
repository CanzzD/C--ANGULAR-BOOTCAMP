using System;

namespace ClassMetotDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.Name = "Atakan";
            customer1.Surname = "Yılmaz";
            customer1.Balance = 50000;

            Customer customer2 = new Customer();
            customer2.Name = "Can";
            customer2.Surname = "Özdemir";
            customer2.Balance = 100000;

            Customer customer3 = new Customer();
            customer3.Name = "Samet";
            customer3.Surname = "Aktaş";
            customer3.Balance = 20000;


            CustomerManager customerManager = new CustomerManager();


            customerManager.MusteriEkle(customer1);
            customerManager.MusteriEkle(customer2);
            customerManager.MusteriEkle(customer3);

            customerManager.CustomerList();

            customerManager.CustomerDelete(customer1);
            customerManager.CustomerDelete(customer2);
            customerManager.CustomerDelete(customer3);




        }
    }
}
