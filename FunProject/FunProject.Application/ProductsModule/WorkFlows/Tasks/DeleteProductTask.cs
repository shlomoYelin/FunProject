using FunProject.Application.Data.Products.Command;
using FunProject.Application.ProductsModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using FunProject.Domain.Logger;
using FunProject.Domain.Mapper;
using FunProject.Domain.Models;
using System;

namespace FunProject.Application.ProductsModule.WorkFlows.Tasks
{
    public class DeleteProductTask : IDeleteProductTask
    {

        private readonly ILoggerAdapter<DeleteProductTask> _logger;
        private readonly IMapperAdapter _mapperAdapter;

        private readonly IDeleteProductCommand _deleteProductCommand;

        public DeleteProductTask(
            ILoggerAdapter<DeleteProductTask> loggerAdapter,
            IMapperAdapter mapperAdapter,
            IDeleteProductCommand deleteProductCommand)
        {
            _logger = loggerAdapter;
            _mapperAdapter = mapperAdapter;
            _deleteProductCommand = deleteProductCommand;
        }


        public ActionStatusModel Delete(Product product)
        {
            _logger.LogInformation("Method DeleteProduct Invoked.");
            try
            {
                _deleteProductCommand.Delete(product);
                return new ActionStatusModel() { Success = true, Message = "" };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Method DeleteProduct failed.");
                return new ActionStatusModel() { Success = false, Message = "Product delete failed ." };
            }
        }
    }
}
