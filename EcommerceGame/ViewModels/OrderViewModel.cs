using EcommerceGame.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace EcommerceGame.PL.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public int User_ID { get; set; }

        public User user { get; set; } // Navigation property
        public ICollection<Order_Item> order_Items { get; set; }
    }
}
