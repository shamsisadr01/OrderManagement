namespace OrderManagement.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; } = null!;

        public decimal Price { get; private set; }

        public Inventory Inventory { get; private set; } = null!;

        private Product()
        {

        }
        public Product(string name, decimal price, int initialQuantity)
        {
            Guard(name, price);

            Name = name;
            Price = price;
            Inventory = new Inventory(initialQuantity);
        }


        public void UpdateInformation(string name, decimal price)
        {
            Guard(name, price);
            Name = name;
            Price = price;
        }

        private void Guard(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Product name is required.");

            if (price <= 0)
                throw new ArgumentException("Product price must be greater than zero.");
        }
    }
}
