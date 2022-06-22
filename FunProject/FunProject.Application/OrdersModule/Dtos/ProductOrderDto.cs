namespace FunProject.Application.ProductOrderModule.Dtos
{
    public class ProductOrderDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductDescription { get; set; }
    }
}
