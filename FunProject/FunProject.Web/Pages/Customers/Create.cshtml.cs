using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.ActivityLogModule.Services.Interfaces;

namespace FunProject.Web.Pages.Customers
{
    public class CreateModel : PageModel
    {
        private readonly IProductsService _customersService;
        private readonly IActivityLogService _activityLogService;

        public CreateModel(IProductsService customersService , IActivityLogService activityLogService)
        {
            _customersService = customersService;
            _activityLogService = activityLogService;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CustomerDto Customer { get; set; }

        public  IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _customersService.CreateCustomer(Customer);

            return RedirectToPage("./Index");
        }
    }
}
