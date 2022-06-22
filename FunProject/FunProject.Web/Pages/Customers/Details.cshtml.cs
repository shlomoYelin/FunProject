using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FunProject.Application.CustomersModule.Dtos;

namespace FunProject.Web.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly IProductsService _customersService;

        public DetailsModel(IProductsService customersService)
        {
            _customersService = customersService;
        }

        public CustomerDto Customer { get; set; }

        public  IActionResult OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer =  _customersService.GetCustomer(id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
