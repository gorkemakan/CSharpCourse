using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.firstName = "Görkem";
            customer1.LastName = "Akan";
            customer1.Age = 16;
            customer1.NationalIdentity = "12345678910";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.firstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.Age = 30;
            customer2.NationalIdentity = "2345678911";

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Update(customer2);


        }
    }
}
