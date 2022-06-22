using FunProject.Application.CustomersModule.Dtos;
using System.Collections.Generic;
using FunProject.Application.CustomersModule.WorkFlows.Interfaces;
using FunProject.Application.CustomersModule.WorkFlows.Tasks.Interfaces;

namespace FunProject.Application.CustomersModule.WorkFlows
{
    public class GetAllCustomersWorkFlow : IGetAllCustomersWorkFlow
    {
        private readonly IGetAllCustomersTask _getAllCustomersTask;

        public GetAllCustomersWorkFlow(IGetAllCustomersTask getAllCustomersTask)
        {
            _getAllCustomersTask = getAllCustomersTask;
        }
        public IList<CustomerDto> Get()
        {
            return _getAllCustomersTask.Get();
        }
    }
}
