using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagement.Domain.Entities;
using OrderManagement.Infrastructure.Persistence.Seed;

namespace OrderManagement.Infrastructure.Persistence.Configurations
{
    public class InventoryConfiguration : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.ToTable("Inventories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Quantity).IsRequired();

            builder.HasIndex(x => x.ProductId).IsUnique();

            builder.ToTable(table => table.HasCheckConstraint("CK_Inventories_Quantity", "\"Quantity\" >= 0"));

            builder.HasData(SeedData.Inventories);
        }
    }
}
