using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.ActivityLogModule.Services.Interfaces;

namespace FunProject.Web.Pages.Customers
{
    public class DeleteModel : PageModel
    {
        private readonly IProductsService _customersService;
        private readonly IActivityLogService _activityLogService;


        public DeleteModel(IProductsService customersService , IActivityLogService activityLogService)
        {
            _customersService = customersService;
            _activityLogService = activityLogService;
        }

        [BindProperty]
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

        public  IActionResult OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var customer = await _customersService.GetCustomer(id);

             _customersService.DeleteCustomer(id);

            return RedirectToPage("./Index");
        }
    }
}
