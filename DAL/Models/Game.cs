using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class Game
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Img_Url { get; set; }
        public DateTime Realese_Date { get; set; }
        public int Rated_Age { get; set; }
        public int Price { get; set; }
        public int Discount { get; set; }
        public ICollection<AddToCart> addToCarts { get; set; }
        public ICollection<Order_Item> order_Items { get; set; }
        public ICollection<Platform> platforms { get; set; }


    }
}
