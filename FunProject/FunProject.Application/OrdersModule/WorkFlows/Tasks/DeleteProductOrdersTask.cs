using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Domain.Entities;
using System;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class DeleteProductOrdersTask : IDeleteProductOrdersTask
    {
        private readonly IDeleteProductOrderRangeCommand _deleteProductOrderRangeCommand;

        public DeleteProductOrdersTask(IDeleteProductOrderRangeCommand deleteProductOrderRangeCommand)
        {
            _deleteProductOrderRangeCommand = deleteProductOrderRangeCommand;
        }

        public void Delete(IList<ProductOrder> productOrders)
        {
            try
            {
                _deleteProductOrderRangeCommand.Delete(productOrders);
            }
            catch (Exception)
            {
                throw new Exception("Product deletet faild");
            }
        }
    }
}
