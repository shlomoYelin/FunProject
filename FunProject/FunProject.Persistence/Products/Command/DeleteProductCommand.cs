using FunProject.Application.Data.Products.Command;
using FunProject.Domain.Entities;


namespace FunProject.Persistence.Products.Command
{
    public class DeleteProductCommand : IDeleteProductCommand
    {
        private readonly AppDbContext _appDbContext;

        public DeleteProductCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Delete(Product product)
        {
            _appDbContext.Products.Remove(product);
            _appDbContext.SaveChangesAsync();
        }
    }
}
