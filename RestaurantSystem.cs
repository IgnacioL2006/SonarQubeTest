using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class RestaurantSystem
    {
        public Inventory Stock { get; set; }
        public List<Order> activeOrders { get; set; }

        public RestaurantSystem()
        {
            Stock = new Inventory();
            activeOrders = new List<Order>();
        }

        public bool ProcessCustomerOrder(string customer, string itemName)
        {
            if (Stock.RequestProduct(itemName))
            {
                var order = new Order();
                var p = new Product(itemName, 15.0f, 1);
                order.AddProduct(p);
                order.CreateOrder(customer, order.Items);
                activeOrders.Add(customer);
                return true;
            }
            return false;
        }
    }
}
