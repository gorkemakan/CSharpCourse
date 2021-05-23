using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.firstName + " " + customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer updated: " + customer.firstName + " " + customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.firstName + " " + customer.LastName);
        }
    }
}
