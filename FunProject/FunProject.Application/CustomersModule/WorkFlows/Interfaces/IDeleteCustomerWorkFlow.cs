using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows.Interfaces
{
    public interface IDeleteCustomerWorkFlow
    {
        ActionStatusModel Delete(int id);
    }
}
