using EcommerceGame.DAL.Models;

namespace EcommerceGame.PL.ViewModels
{
    public class OrderItemViewModel
    {
        public int Order_ID { get; set; }
        public Order order { get; set; } // Navigation property

        public int Game_ID { get; set; }
        public Game game { get; set; } // Navigation property
    }
}
