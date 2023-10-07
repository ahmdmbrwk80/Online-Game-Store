using Microsoft.AspNetCore.Mvc;

namespace EcommerceGame.PL.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
