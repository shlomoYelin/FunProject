using FunProject.Domain.Entities;
using FunProject.Domain.Models;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces
{
    public interface IDeleteOrderTask
    {
        ActionStatusModel Delete(Order order);
    }

}
