using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Products.Command
{
    public interface IDeleteProductCommand
    {
        void Delete(Product product);
    }
}
