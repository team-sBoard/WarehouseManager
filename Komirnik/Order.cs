namespace Komirnik
{
    public class Order
    {
        public string name;
        public string origin;
        public int quantity;

        public Order(string name, string origin, int quantity)
        {
            this.name = name;
            this.origin = origin;
            this.quantity = quantity;
        }
    }
}
