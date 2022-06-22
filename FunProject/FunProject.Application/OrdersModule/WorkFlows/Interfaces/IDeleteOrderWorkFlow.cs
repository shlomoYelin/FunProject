using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows.Interfaces
{
    public interface IDeleteOrderWorkFlow
    {
        ActionStatusModel Delete(int id);
    }
}
