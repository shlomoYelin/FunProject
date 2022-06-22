using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FunProject.Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            //builder
            //   .HasOne<Customer>(o => o.Customer)
            //   .WithMany(c => c.Orders)
            //   .HasForeignKey(o => o.CustomerId);

        }
    }
}
