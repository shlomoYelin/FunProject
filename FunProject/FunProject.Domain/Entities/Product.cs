using System.Collections.Generic;

namespace FunProject.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public IList<ProductOrder> ProductOrders { get; set; }
    }
}
