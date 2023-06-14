using System;
using System.Collections.Generic;
using System.Text;

namespace EventHandler_demo
{
    class ProductArgs : EventArgs
    {
        public double OldPrice { get; set; }
    }
    class Product
    {
        public event EventHandler<ProductArgs> PriceChange;
        public string Name { get; set; }
        double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    return;
                }
                if (price != value)
                {
                    double oldPrice = value;
                    price = value;
                    PriceChange?.Invoke(this, new ProductArgs { OldPrice = oldPrice });
                }
                price = value;
            }
        }
        public byte Count { get; set; }
        public Product(string name, double price, byte count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public Product() : this("Noname", 0, 0) { }
        public override string ToString()
        {
            return $"Product : {Name, -15}, Price : {Price, -12}, Count : {Count, -8}";
        }
    }
}
