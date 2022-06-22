using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class GetAllProductsWorkFlow : IGetAllProductWorkFlow
    {
        private readonly IGetAllProductsTask _getAllCustomersTask;

        public GetAllProductsWorkFlow(IGetAllProductsTask getAllCustomersAndMappingToDtoTask)
        {
            _getAllCustomersTask = getAllCustomersAndMappingToDtoTask;
        }
        public IList<ProductDto> Get()
        {
            return _getAllCustomersTask.Get();
        }
    }
}
