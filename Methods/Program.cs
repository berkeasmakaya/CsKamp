using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Explanation = "Amasya elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 20;
            product2.Explanation = "Diyarbakır karpuzu";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("---------------Methods-----------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product2);
            sepetManager.Add(product1);

            sepetManager.Add2("elma", "yeşil elma", 12);
        }
    
    }
}
