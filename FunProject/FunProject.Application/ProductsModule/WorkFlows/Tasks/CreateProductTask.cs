using FunProject.Application.Data.Products.Command;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class CreateProductTask : ICreateProductTask
    {
        private readonly ILoggerAdapter<CreateProductTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly ICreateProductCommand _createproductCommand;
        public CreateProductTask(
            ILoggerAdapter<CreateProductTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            ICreateProductCommand createproductCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _createproductCommand = createproductCommand;
        }

        public ActionStatusModel Create(ProductDto product)
        {
            _logger.LogInformation("Method CreateProduct Invoked.");
            try
            {
                _createproductCommand.Create(_mapperAdapter.Map<Product>(product));
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method CreateProduct failed.");
                return new ActionStatusModel() { Success = false, Message = "Product creation failed ." };
            }
        }
    }
}
