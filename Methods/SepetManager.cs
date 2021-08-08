using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("It has been added into the basket :" + product.Name);
        }

        //Encapsulation
        public void Add2(string name, string explanation, double price)
        {
            Console.WriteLine("It has been added into the basket :" + name);
        }
    }
}
