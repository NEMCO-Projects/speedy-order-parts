using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpeedyOrderPages.Data;
using SpeedyOrderPages.Models;

namespace SpeedyOrderPages.Pages
{
    public class OrderModel : PageModel
    {
        private readonly SpeedyOrderDbContext _context;

        public OrderModel(SpeedyOrderDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string OrderName { get; set; }

        [BindProperty]
        public string OrderItem { get; set; }

        [BindProperty]
        public int Quantity { get; set; }

        public bool Submitted { get; set; } = false;

        public void OnGet()
        {
        }

        public async Task OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var order = new Order
                {
                    OrderName = OrderName,
                    OrderItem = OrderItem,
                    Quantity = Quantity
                };

                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
                Submitted = true;
            }
        }
    }
}
