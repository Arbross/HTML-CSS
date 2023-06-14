using System;

namespace EventHandler_demo
{
    class Program
    {
        static void Main()
        {
            Product pizza = new Product("Margarita", 120, 250);
            Console.WriteLine(pizza);

            Customer ivan = new Customer() { Name = "Ivan" };
            pizza.PriceChange += ivan.Handler;
            pizza.Price = 117;
        }
    }
}
