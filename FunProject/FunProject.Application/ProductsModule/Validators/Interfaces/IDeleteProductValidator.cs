using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.Validators.Interfaces
{
    public interface IDeleteProductValidator
    {
        ActionStatusModel Validate(int productId);
    }
}
