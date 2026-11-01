using Bogus;

namespace OrderManagement.Infrastructure.Persistence.Seed
{
    public static class SeedData
    {
        static SeedData()
        {
            Randomizer.Seed = new Random(12345);

            EnglishFaker = new Faker("en");
            PersianFaker = new Faker("fa");

            Customers = GenerateCustomers();
            Products = GenerateProducts();
            Inventories = GenerateInventories();
        }

        private static readonly Faker EnglishFaker;
        private static readonly Faker PersianFaker;

        public static readonly object[] Customers;

        public static readonly object[] Products;

        public static readonly object[] Inventories;

        private static object[] GenerateCustomers()
        {
            return Enumerable.Range(1, 50)
                .Select(i => new
                {
                    Id = i,
                    FirstName = PersianFaker.Name.FirstName(),
                    LastName = PersianFaker.Name.LastName(),
                    Email = $"{EnglishFaker.Name.FullName().ToLower().Replace(" ", ".")}{i}@{EnglishFaker.Internet.DomainName()}"
                })
                .Cast<object>()
                .ToArray();
        }

        private static object[] GenerateProducts()
        {
            return Enumerable.Range(1, 200)
                .Select(i => new
                {
                    Id = i,
                    Name = PersianFaker.Commerce.ProductName(),
                    Price = Math.Round( PersianFaker.Random.Decimal(100000, 50000000), 2)
                })
                .Cast<object>()
                .ToArray();
        }

        private static object[] GenerateInventories()
        {
            return Enumerable.Range(1, 200)
                .Select(i => new
                {
                    Id = i,
                    ProductId = i,
                    Quantity = PersianFaker.Random.Int(10, 500)
                })
                .Cast<object>()
                .ToArray();
        }
    }
}
