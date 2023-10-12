using EcommerceGame.DAL.Models;
using Humanizer.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceGame.BLL;

namespace EcommerceGame.BLL.Interfaces
{
    public interface IHomeRepository
    {
        Task<IEnumerable<Game>> GetGames(string sTerm = "", int categoryId = 0);
        Task<IEnumerable<Category>> Categories();


    }
}
