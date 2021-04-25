using System.Collections.Generic;

namespace Komirnik
{
    public class Product
    {
        public string name;
        public string origin;
        public string type;
        public int quantity;
        public List<Product> products;

        public Product(List<Product> products)
        {
            this.products = products;
        }

        public Product(string name, string origin, string type, int quantity)
        {
            this.name = name;
            this.origin = origin;
            this.type = type;
            this.quantity = quantity;
        }
    }
}
