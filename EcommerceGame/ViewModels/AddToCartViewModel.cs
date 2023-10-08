using EcommerceGame.DAL.Models;

namespace EcommerceGame.PL.ViewModels
{
    public class AddToCartViewModel
    {
        public int User_ID { get; set; }// Foreign key property

        public User user { get; set; } // Navigation property
        public int Game_ID { get; set; }
        public Game game { get; set; }

    }
}
