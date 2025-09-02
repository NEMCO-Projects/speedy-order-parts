using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SpeedyOrderPages.Data;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Pages
{
    public class EditOrderModel : PageModel
    {
        private readonly SpeedyOrderDbContext _context;
        public EditOrderModel(SpeedyOrderDbContext context) => _context = context;

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
            if (!ModelState.IsValid) return Page();

            _context.Attach(Order).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("/Orders");
        }
    }
}
