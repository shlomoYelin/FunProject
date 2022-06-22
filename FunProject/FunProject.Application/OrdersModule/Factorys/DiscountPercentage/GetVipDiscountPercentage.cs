using FunProject.Application.OrdersModule.Factorys.DiscountPercentage.Interfaces;

namespace FunProject.Application.OrdersModule.Factorys.DiscountPercentage
{
    internal class GetVipDiscountPercentage : IGetUserDiscountPercentage
    {
        public float GetDiscountPercentage()
        {
            return 40;
        }
    }
}
