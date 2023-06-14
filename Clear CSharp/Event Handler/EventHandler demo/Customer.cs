using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandler_demo
{
    class Customer
    {
        public string Name { get; set; }

        public void Handler(object sender, ProductArgs e)
        {
            Product product = sender as Product;
            if (product != null)
            {
                Console.WriteLine($"Customer {Name} has notified about price changes {product.Name}/Old price : {e.OldPrice}/New price {product.Price}");
            }
        }
    }
}
