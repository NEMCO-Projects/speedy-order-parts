using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpeedyOrderPages.Pages
{
    public class OrderModel : PageModel
    {
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

        public void OnPost()
        {
            Submitted = true;
            // Here you can later save the order to a database
        }
    }
}
