namespace FunProject.Application.Data.Products.Query
{
    public interface IGetProductPriceQuery
    {
        float Get(int productId);
    }
}
