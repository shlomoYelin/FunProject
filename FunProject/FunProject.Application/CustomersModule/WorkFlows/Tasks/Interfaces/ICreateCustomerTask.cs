using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface ICreateCustomerTask
    {
        ActionStatusModel Create(CustomerDto customer);
    }
}
