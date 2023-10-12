using EcommerceGame.BLL.Interfaces;
using EcommerceGame.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceGame.PL.Controllers
{
    public class CategoryController : Controller
    {


        //public IActionResult Index()
        //{
        //    return View();
        //}

        private readonly IHomeRepository _homeRepository;

        public CategoryController(IHomeRepository homeRepository)
        {
            _homeRepository = homeRepository;
        }


        public async Task<IActionResult> Index(string sterm = "", int categoryId = 0)
        {
            IEnumerable<Game> games = await _homeRepository.GetGames(sterm, categoryId);
            IEnumerable<Category> categories = await _homeRepository.Categories();
            GameDisplayModel gameModel = new GameDisplayModel
            {
                Games = games,
                Categories = categories,
                STerm = sterm,
                CategoryId = categoryId
            };
            return View(gameModel);
        }
    }
}
