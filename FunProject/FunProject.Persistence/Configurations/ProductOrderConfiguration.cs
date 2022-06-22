using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunProject.Persistence.Configurations
{
    public class ProductOrderConfiguration : IEntityTypeConfiguration<ProductOrder>
    {
        public void Configure(EntityTypeBuilder<ProductOrder> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder
                .HasOne<Order>(po => po.Order)
                .WithMany(o => o.ProductOrders)
                .HasForeignKey(po => po.OrderId);

            builder
                .HasOne<Product>(po => po.Product)
                .WithMany(o => o.ProductOrders)
                .HasForeignKey(po => po.ProductId);
        }
    }
}
