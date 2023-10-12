using EcommerceGame.DAL.Models;
using EcommerceGame.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EcommerceGame.DAL.Models.DTOs;
using EcommerceGame.BLL.Repositories;
using EcommerceGame.BLL.Interfaces;



namespace EcommerceGame.Controllers
{// test pull
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}