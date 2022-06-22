using FunProject.Application.CustomersModule.Dtos;
using System.Collections.Generic;

namespace FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces
{
    public interface IGetAllCustomersTask
    {
        IList<CustomerDto> Get();
    }
}
