using FunProject.Domain.Models;

namespace FunProject.Application.ProductsModule.WorkFlows.Interfaces
{
    public interface IDeleteProductWorkFlow
    {
        ActionStatusModel Delete(int id);
    }
}
