using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Interfaces;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProject.Application.ProductsModule.WorkFlows
{
    public class GetProductsBySearchValueWorkFlow : IGetProductsBySearchValueWorkFlow
    {
        private readonly IGetProductsBySearchValueTask _getProductsBySearchValueTask;

        public GetProductsBySearchValueWorkFlow(IGetProductsBySearchValueTask getProductsBySearchValueTask)
        {
            _getProductsBySearchValueTask = getProductsBySearchValueTask;
        }

        public IList<ProductDto> Get(string searchValue)
        {
            return _getProductsBySearchValueTask.Get(searchValue);    
        }
    }
}
