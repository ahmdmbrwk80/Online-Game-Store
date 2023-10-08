using EcommerceGame.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace EcommerceGame.PL.ViewModels
{
    public class GameViewModel
    {
        // test commit
        public int Id { get; set; }
        
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 5)]
        public string Description { get; set; }
        [Required]
        public string Category { get; set; }
        public string Img_Url { get; set; }
        public DateTime Realese_Date { get; set; }
        [Range(15, 55)]
        public int Rated_Age { get; set; }
        [Required]
        public int Price { get; set; }
        public int Discount { get; set; }
        public ICollection<AddToCart> addToCarts { get; set; }
        public ICollection<Order_Item> order_Items { get; set; }
        public ICollection<Platform> platforms { get; set; }
    }
}
