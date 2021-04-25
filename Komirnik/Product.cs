namespace Komirnik
{
    public class Product
    {
        public string Name;
        public string Origin;
        public string Type;
        public int Quantity;

        public Product(string name, string origin, string type, int quantity)
        {
            Name = name;
            Origin = origin;
            Type = type;
            Quantity = quantity;
        }
    }
}
