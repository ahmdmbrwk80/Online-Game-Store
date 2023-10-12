using Demo.DAL.Contexts;
using EcommerceGame.BLL.Interfaces;
using EcommerceGame.DAL.Models;
using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.BLL.Repositories
{
    public class HomeRepository: IHomeRepository
    {
        private readonly FinalMVCContext _db;

        public HomeRepository(FinalMVCContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Category>> Categories()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<IEnumerable<Game>> GetGames(string sTerm = "", int categoryId = 0)
        {
            sTerm = sTerm.ToLower();
            IEnumerable<Game> games = await (from game in _db.games
                join category in _db.Categories
                on game.CategoryId equals category.Id
       where string.IsNullOrWhiteSpace(sTerm) || (game != null && game.Name.ToLower().StartsWith(sTerm))
        select new Game
              {
               Id = game.Id,
               Img_Url = game.Img_Url,
               platforms = game.platforms,
               Name = game.Name,
              CategoryId = game.CategoryId,
               Price = game.Price,
              CategoryName = category.CategoryName
                      }
                         ).ToListAsync();
            if (categoryId > 0)
            {

                games = games.Where(a => a.CategoryId == categoryId).ToList();
            }
            return games;

        }
    }
}
