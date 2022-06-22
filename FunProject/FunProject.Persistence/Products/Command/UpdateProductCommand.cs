using FunProject.Application.Data.Products.Command;
using FunProject.Domain.Entities;

namespace FunProject.Persistence.Products.Command
{
    public class UpdateProductCommand : IUpdateProductCommand
    {
        private readonly AppDbContext _appDbContext;

        public UpdateProductCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Update(Product product)
        {
            _appDbContext.Products.Update(product);
            _appDbContext.SaveChangesAsync();
        }
    }
}
