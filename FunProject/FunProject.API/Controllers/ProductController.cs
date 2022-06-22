using FunProject.Application.ProductsModule.Dtos;
using FunProject.Application.ProductsModule.Services.Interfaces;
using FunProject.Domain.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductsService _productsService;

        public ProductController(IProductsService productsService)
        {
            _productsService = productsService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IList<ProductDto> Get()
        {
            return _productsService.GetAllProducts();
        }

        [HttpGet("{searchValue}")]
        public IList<ProductDto> Get(string searchValue)
        {
            return _productsService.GetProductsBySearchValue(searchValue);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionStatusModel Post([FromBody] ProductDto product)
        {
            return _productsService.CreateProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public ActionStatusModel Put([FromBody] ProductDto product)
        {
            return _productsService.UpdateProduct(product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionStatusModel Delete(int id)
        {
            return _productsService.DeleteProduct(id);
        }
    }
}
