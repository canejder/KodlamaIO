using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        private List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>();
        }

        public void AddCustomer(Customer customer)
        {
            if (customer != null && !_customers.Contains(customer))
            {
                _customers.Add(customer);
                Console.WriteLine("Müşteri başarıyla eklendi!");
            }
            else
            {
                Console.WriteLine("Müşteri ekleme başarısız!");
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            if (customer != null && _customers.Contains(customer))
            {
                _customers.Remove(customer);
                Console.WriteLine("Müşteri başarıyla silindi!");
            }
            else
            {
                Console.WriteLine("Müşteri silinemedi!");
            }
        }

        public void ListCustomer()
        {
            foreach (Customer customer in _customers)
            {
                Console.WriteLine("ID:" + customer.Id +
                                  "\nMüşteri Adı: " + customer.FirstName +
                                  " Soyadı: " + customer.LastName +
                                  "\nTelefon: " + customer.Phone +
                                  "\nAdres: " + customer.Address +
                                  "\n***************************************");
            }
        }

        public Customer GetCustomer(int id)
        {
            foreach (Customer customer in _customers)
            {
                if (id == customer.Id)
                {
                    return customer;
                }
            }
            return null;
        }
        public Customer GetCustomer(string lastName)
        {
            foreach (Customer customer in _customers)
            {
                if (lastName == customer.LastName)
                {
                    return customer;
                }
            }
            return null;
        }

        public void NotifyCustomer(Customer customer, string message)
        {
            customer.Update(message);
        }
    }
}