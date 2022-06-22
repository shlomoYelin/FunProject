using FunProject.Domain.Entities;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface IDeleteCustomerTask
    {
        ActionStatusModel Delete(Customer customer);
    }

}
