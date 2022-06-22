using FunProject.Application.CustomersModule.Dtos;
using FunProject.Domain.Models;

namespace FunProject.Application.CustomersModule.WorkFlows.Interfaces
{
    public interface IUpdateCustomerWorkFlow
    {
        ActionStatusModel Update(CustomerDto customer);
    }
}
