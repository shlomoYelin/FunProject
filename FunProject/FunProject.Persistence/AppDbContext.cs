using FunProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FunProject.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        { }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}