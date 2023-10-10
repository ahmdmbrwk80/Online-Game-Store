using Microsoft.AspNetCore.Mvc;

namespace EcommerceGame.PL.Controllers
{
    public class UserOrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserOrders()
        {
            return View();
        }
    }
}
