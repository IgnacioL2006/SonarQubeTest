using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; } = string.Empty;
        public List<Product> Items { get; set; } 
        public string Status { get; set; }

        public Order()
        {
            Items = new List<Product>();
            Status = "pending";
        }

        public void CreateOrder(string customer)
        {
            Customer = customer;
            Status = "created";
            Console.WriteLine("Order created for: " + customer);
        }

        public void AddProduct(Product product)
        {
            if (product.HasStock())
            {
                Items.Add(product);
            }
        }
        public float GetTotal()
        {
            float total = 0;
            foreach (Product product in Items)
            {
                total = total + product.Price;
            }
            return total;
        }

        public void ShowOrder()
        {
            Console.WriteLine("Order #" + Id);
            Console.WriteLine("Customer: " + Customer);
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Items:");
            foreach (Product product in Items)
            { Console.WriteLine("  - " + product.Name + " - $" + product.Price); }
            Console.WriteLine("Total: $" + GetTotal());
        }
    }
}
