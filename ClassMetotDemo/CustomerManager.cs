using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>();
        }

        public void MusteriEkle(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("Müşteri Başarıyla Eklendi:" + " " + customer.Name + " " + customer.Surname + " " + customer.Balance);
        }
        public void CustomerDelete(Customer customer)
        {
            _customers.Remove(customer);
            Console.WriteLine("Kalan Müşteriler");

            foreach (Customer customerA in _customers)
            {
                Console.WriteLine(customerA.Name);
                Console.WriteLine(customerA.Surname);
                Console.WriteLine(customerA.Balance);
                Console.WriteLine("--------------");
            }

        }

        public void CustomerList()
        {
            foreach (var customer in _customers)
            {
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Surname);
                Console.WriteLine(customer.Balance);
                Console.WriteLine("-----------");
            }
        }
    }
}
