using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;
using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.Data.Products.Command;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class UpdateProductTask : IUpdateProductTask
    {
        private readonly ILoggerAdapter<UpdateProductTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly IUpdateProductCommand _updateProductCommand;
        public UpdateProductTask(
            ILoggerAdapter<UpdateProductTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IUpdateProductCommand updateProductCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _updateProductCommand = updateProductCommand;
        }

        public ActionStatusModel Update(ProductDto product)
        {
            _logger.LogInformation("Method UpdateProduct Invoked.");
            try
            {
                _updateProductCommand.Update(_mapperAdapter.Map<Product>(product));
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method UpdateProduct failed.");
                return new ActionStatusModel() { Success = false, Message = "Product update fialed ." };
            }
        }
    }
}
