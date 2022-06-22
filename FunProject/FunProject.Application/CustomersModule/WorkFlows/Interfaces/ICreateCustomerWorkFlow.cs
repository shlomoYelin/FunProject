using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows.Interfaces
{
    public interface ICreateCustomerWorkFlow
    {
        ActionStatusModel Create(CustomerDto customer);
    }
}
