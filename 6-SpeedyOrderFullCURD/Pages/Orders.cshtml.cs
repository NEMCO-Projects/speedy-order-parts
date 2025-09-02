using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SpeedyOrderPages.Data;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly SpeedyOrderDbContext _context;

        public OrdersModel(SpeedyOrderDbContext context)
        {
            _context = context;
        }

        public IList<Order> Orders { get; set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.AsNoTracking().ToListAsync();
        }
    }
}
