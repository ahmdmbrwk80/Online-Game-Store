using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class AddToCart
    {
        public int User_ID { get; set; }// Foreign key property

        public User user { get; set; } // Navigation property
        public int Game_ID { get; set; }
        public Game game { get; set; }

    }
}
