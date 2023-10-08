using EcommerceGame.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace EcommerceGame.PL.ViewModels
{
    public class PlatformViewModel
    {
        [Required]
        public string Name { get; set; }
        public int Game_ID { get; set; }
        public Game game { get; set; } // Navigation property
    }
}
