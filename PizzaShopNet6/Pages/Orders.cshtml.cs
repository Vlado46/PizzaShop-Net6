using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShopNet6.Data;
using PizzaShopNet6.Models;

namespace PizzaShopNet6.Pages
{
    public class OrdersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
