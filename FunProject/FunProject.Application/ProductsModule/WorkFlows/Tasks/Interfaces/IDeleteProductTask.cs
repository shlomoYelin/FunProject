using FunProject.Domain.Entities;
using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces
{
    public interface IDeleteProductTask
    {
        ActionStatusModel Delete(Product id);
    }

}
