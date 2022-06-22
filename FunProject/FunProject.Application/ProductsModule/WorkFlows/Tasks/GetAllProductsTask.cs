using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using System;
using System.Collections.Generic;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.Data.Products.Query;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class GetAllProductsTask : IGetAllProductsTask
    {
        private readonly IMapperAdapter _mapperAdapter;
        private readonly ILoggerAdapter<GetAllProductsTask> _logger;

        private readonly IAllProductsQuery _getAllProductsQuery;
        public GetAllProductsTask(
            ILoggerAdapter<GetAllProductsTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IAllProductsQuery allProductsQuery)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _getAllProductsQuery = allProductsQuery;
        }

        public IList<ProductDto> Get()
        {
            _logger.LogInformation("Method GetAllProducts Invoked.");
            try
            {
                var result = _getAllProductsQuery.Get();
                var mappedResult = _mapperAdapter.Map<IList<ProductDto>>(result.Result);
                return mappedResult;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method GetAllProducts failed.");
                throw;
            }
        }
    }
}
