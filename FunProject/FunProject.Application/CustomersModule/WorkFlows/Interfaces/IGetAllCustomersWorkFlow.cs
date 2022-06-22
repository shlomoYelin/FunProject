using FunProject.Application.CustomersModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Interfaces
{
    public interface IGetAllCustomersWorkFlow
    {
        IList<CustomerDto> Get();
    }
}
