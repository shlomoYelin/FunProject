using FunProject.Application.Data.ProductOrders.Command;
using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using FunProject.Domain.Mapper;
using System;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class CreateProductOrderTask : ICreateProductOrderTask
    {
        private readonly ICreateProductOrderCommand _createProductOrderCommand;
        private readonly IMapperAdapter _mapper;

        public CreateProductOrderTask(ICreateProductOrderCommand createProductOrderCommand, IMapperAdapter mapper)
        {
            _createProductOrderCommand = createProductOrderCommand;
            _mapper = mapper;
        }
        public void Create(ProductOrderDto productOrder)
        {
            try
            {
                productOrder.Id = 0;
                _createProductOrderCommand.Create(_mapper.Map<ProductOrder>(productOrder));
            }
            catch (Exception)
            {
                throw new Exception($"{productOrder.ProductDescription} create faild");
            }
        }
    }
}
