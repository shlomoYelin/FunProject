using FunProject.Application.OrdersModule.Dtos;
using FunProject.Application.OrdersModule.Services.Interfaces;
using FunProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrderController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IList<OrderDto> Get()
        {
            return _ordersService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public OrderDto Get(int id)
        {
            return _ordersService.GetOrder(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionStatusModel Post([FromBody] OrderDto order)
        {
            return _ordersService.CreateOrder(order);
        }

        [HttpPut]
        public ActionStatusModel Put([FromBody] OrderDto order)
        {
            return _ordersService.UpdateOrder(order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionStatusModel Delete(int id)
        {
            return _ordersService.DeleteOrder(id);
        }
    }
}
