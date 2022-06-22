using Microsoft.AspNetCore.Mvc.RazorPages;
using FunProject.Application.CustomersModule.Dtos;

namespace FunProject.Web.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly IProductsService _customersService;

        public IndexModel(IProductsService customersService)
        {
            _customersService = customersService;
        }

        public IList<CustomerDto> Customer { get;set; }

        public void OnGetAsync()
        {
            Customer =  _customersService.GetAllCustomers();
        }
    }
}