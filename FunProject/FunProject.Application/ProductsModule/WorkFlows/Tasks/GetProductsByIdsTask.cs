using FunProject.Application.Data.Products.Query;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using System.Collections.Generic;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class GetProductsByIdsTask : IGetProductsByIdsTask
    {
        private readonly IGetProductsDesByIdsQuery _getProductsDesByIdsQuery;

        public GetProductsByIdsTask(IGetProductsDesByIdsQuery getProductsDesByIdsQuery)
        {
            _getProductsDesByIdsQuery = getProductsDesByIdsQuery;
        }
        public IList<(int, string)> Get(IList<int> ids)
        {
            return _getProductsDesByIdsQuery.Get(ids);
        }
    }
}
