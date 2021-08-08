using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName + "has been added!");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name+ " " + customer.LastName + "has been deleted!");
        }

        public void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.LastName);
            }
            Console.WriteLine("Customers have been listed");
        }
    }
}
