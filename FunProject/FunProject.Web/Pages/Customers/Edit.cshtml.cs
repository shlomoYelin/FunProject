using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FunProject.Application.CustomersModule.Dtos;
using FunProject.Application.ActivityLogModule.Services.Interfaces;

namespace FunProject.Web.Pages.Customers
{
    public class EditModel : PageModel
    {
        private readonly IProductsService _customersService;
        private readonly IActivityLogService _activityLogService;


        public EditModel(IProductsService customersService ,IActivityLogService activityLogService)
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
        // Uncommint this Method to start the Task
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Task #1
             _customersService.UpdateCustomer(Customer);
          
            return RedirectToPage("./Index");
        }
    }
}
