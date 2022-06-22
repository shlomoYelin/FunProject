using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Products.Command
{
    public interface ICreateProductCommand
    {
        void Create(Product product);
    }
}
