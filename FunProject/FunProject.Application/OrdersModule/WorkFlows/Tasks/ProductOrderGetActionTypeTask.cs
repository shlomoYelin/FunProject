using FunProject.Application.OrdersModule.WorkFlows.Tasks.Interfaces;
using FunProject.Application.ProductOrderModule.Dtos;
using FunProject.Domain.Entities;
using FunProject.Domain.Enums;

namespace FunProject.Application.OrdersModule.WorkFlows.Tasks
{
    public class ProductOrderGetActionTypeTask : IProductOrderGetActionTypeTask
    {
        public ActionType Get(ProductOrder dbProducOrder, ProductOrderDto clientProductOrder)
        {
            if (dbProducOrder == null)
            {
                return ActionType.Create;
            }
            else if (dbProducOrder.Quantity != clientProductOrder.Quantity)
            {
                return ActionType.Update;
            }

            return 0;
        }
    }
}
