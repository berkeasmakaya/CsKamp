using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Furkan";
            customer1.LastName = "Akkaya";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Melih";
            customer2.LastName = "Keskin";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Berke";
            customer3.LastName = "Asmakaya";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            Console.WriteLine("----------------------------------------");

            customerManager.DeleteCustomer(customer2);
            Console.WriteLine("----------------------------------------");

            customerManager.ListCustomer(customers);

        }
    }
}
