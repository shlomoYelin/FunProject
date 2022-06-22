using FunProject.Application.ProductOrderModule.Dtos;
using System;
using System.Collections.Generic;

namespace FunProject.Application.OrdersModule.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public IList<ProductOrderDto> ProductOrders { get; set; }
        public float Payment { get; set; }
        public DateTime Date { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
