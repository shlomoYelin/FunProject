using FunProject.Domain.Entities;

namespace FunProject.Application.Data.Products.Command
{
    public interface IUpdateProductCommand
    {
        void Update(Product product);
    }
}
