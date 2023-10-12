using EcommerceGame.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceGame.PL.Controllers
{
    public class GameController : Controller
    {
        IGameRepository gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Game/GameDetails?gameid=..
        public IActionResult GameDetails(int gameId)
        {
            //var game = gameRepository.GetGame(gameId);
            return View();
        }
    }
}
