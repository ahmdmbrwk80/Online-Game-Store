using EcommerceGame.DAL.Models;

namespace EcommerceGame.BLL.Interfaces
{
    public interface IGameRepository
    {
        Game GetGame(int id);
    }
}