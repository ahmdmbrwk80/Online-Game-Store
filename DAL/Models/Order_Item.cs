using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EcommerceGame.DAL.Models
{
    public class Order_Item
    {
        public int Order_ID { get; set; }
        public Order Order { get; set; } // Navigation property
        public int Id { get; set; }
    
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Game_ID { get; set; }
        public Game game { get; set; } // Navigation property
    }
}
