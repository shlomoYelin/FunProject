using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.CustomersModule.Services.Interfaces;
using FunProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomersService _customersService;

        public CustomerController(ICustomersService customersService)
        {
            _customersService = customersService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public IList<CustomerDto> Get()
        {
            return _customersService.GetAllCustomers();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionStatusModel Post([FromBody] CustomerDto customer)
        {
            return _customersService.CreateCustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut]
        public ActionStatusModel Put([FromBody] CustomerDto customer)
        {
            return _customersService.UpdateCustomer(customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionStatusModel Delete(int id)
        {
            return _customersService.DeleteCustomer(id);
        }
    }
}
