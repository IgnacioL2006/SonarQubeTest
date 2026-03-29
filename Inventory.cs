namespace Restaurant
{
    public class Inventory
    {
        private readonly List<Product> products;
        public Inventory()
        {
            products = new List<Product>();
            products.Add(new Product("Pizza", 10000, 5));
            products.Add(new Product("Cookie", 1000, 8));
            products.Add(new Product("Soda", 2000, 3));
            products.Add(new Product("Salad", 2000, 8));
        }

        public bool RequestProduct(string name)
        {
            var p = products.Find(x => x.Name == name);
            
            if (p != null && p.HasStock())
            {
                p.ReduceStock(1);
                return true;
            }
            return false;
        }
    }
}