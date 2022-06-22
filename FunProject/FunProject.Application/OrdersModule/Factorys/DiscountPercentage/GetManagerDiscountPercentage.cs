using FunProject.Application.OrdersModule.Factorys.DiscountPercentage.Interfaces;

namespace FunProject.Application.OrdersModule.Factorys.DiscountPercentage
{
    internal class GetManagerDiscountPercentage : IGetUserDiscountPercentage
    {
        public float GetDiscountPercentage()
        {
            return 100;
        }
    }
}
