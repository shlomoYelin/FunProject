using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using FunProject.Domain.Mapper;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class UpdateProductOrderTask : IUpdateProductOrderTask
    {
        private readonly IUpdateProductOrderCommand _updateProductOrderCommand;
        private readonly IMapperAdapter _mapperAdapter;

        public UpdateProductOrderTask(IUpdateProductOrderCommand updateProductOrderCommand, IMapperAdapter mapperAdapter)
        {
            _updateProductOrderCommand = updateProductOrderCommand;
            _mapperAdapter = mapperAdapter;
        }
        public void Update(ProductOrderDto productOrder)
        {
            try
            {
                _updateProductOrderCommand.Update(_mapperAdapter.Map<ProductOrder>(productOrder));
            }
            catch (Exception)
            {
                throw new Exception($"{productOrder.ProductDescription} update faild");
            }
        }
    }
}
