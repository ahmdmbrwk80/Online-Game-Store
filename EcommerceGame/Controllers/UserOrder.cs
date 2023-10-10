using Microsoft.AspNetCore.Mvc;

namespace EcommerceGame.PL.Controllers
{
    public class UserOrder : Controller
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
