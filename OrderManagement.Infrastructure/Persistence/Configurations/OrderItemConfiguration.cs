using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagement.Domain.Entities;

namespace OrderManagement.Infrastructure.Persistence.Configurations
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.ToTable("OrderItems");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.OrderId)
                .IsRequired();

            builder.Property(x => x.ProductId)
                .IsRequired();

            builder.Property(x => x.Quantity)
                .IsRequired();

            builder.Property(x => x.UnitPrice)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.HasOne(x => x.Product)
                .WithMany()
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.OrderId);
            builder.HasIndex(x => x.ProductId);

            builder.ToTable(table =>
                table.HasCheckConstraint(
                    "CK_OrderItems_Quantity",
                    "\"Quantity\" > 0"));

            builder.ToTable(table =>
                table.HasCheckConstraint(
                    "CK_OrderItems_UnitPrice",
                    "\"UnitPrice\" > 0"));
        }
    }
}
