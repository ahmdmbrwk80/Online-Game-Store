using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class Order_Item
    {
        public int Order_ID { get; set; }
        public Order order { get; set; } // Navigation property

        public int Game_ID { get; set; }
        public Game game { get; set; } // Navigation property
    }
}
