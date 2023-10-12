using Demo.DAL.Contexts;
using EcommerceGame.BLL.Interfaces;
using EcommerceGame.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.BLL.Repositories
{
    public class GameRepository : IGameRepository
    {
        FinalMVCContext db;

        public GameRepository(FinalMVCContext _db)
        {
            db = _db;
        }

        public Game GetGame(int id)
        {
            return db.games.FirstOrDefault(g => g.Id == id);
        }
    }
}
