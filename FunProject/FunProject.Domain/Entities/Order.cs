using System;
using System.Collections.Generic;

namespace FunProject.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public IList<ProductOrder> ProductOrders { get; set; }
        public float Payment { get; set; }
        public DateTime Date { get; set; }
    }
}
