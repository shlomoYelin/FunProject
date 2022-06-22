using FunProject.Application.OrdersModule.Factorys.DiscountPercentage.Interfaces;

namespace FunProject.Application.OrdersModule.Factorys.DiscountPercentage
{
    internal class GetRegularDiscountPercentage : IGetUserDiscountPercentage
    {
        public float GetDiscountPercentage()
        {
            return 30;
        }
    }
}
