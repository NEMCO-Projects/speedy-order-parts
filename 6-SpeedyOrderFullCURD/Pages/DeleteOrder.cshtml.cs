using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeedyOrderPages.Data;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Pages
{
    public class DeleteOrderModel : PageModel
    {
        private readonly SpeedyOrderDbContext _context;
        public DeleteOrderModel(SpeedyOrderDbContext context) => _context = context;

        [BindProperty]
        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Order = await _context.Orders.FindAsync(id);
            if (Order == null) return RedirectToPage("/Orders");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Order != null)
            {
                _context.Orders.Remove(Order);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/Orders");
        }
    }
}
