using System;

namespace Restaurant
{
    public class Product
    {
        public string Name { get; set; } 
        public float Price { get; set; }
        public int Stock { get; set; }
        public Product(string name, float price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public bool HasStock()
        {
            return Stock > 0;
        }
        public void ReduceStock(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock = Stock - quantity;
            }
        }
        public void IncreaseStock(int quantity)
        {
            Stock = Stock + quantity;
        }
    }
}
