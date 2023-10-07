using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }
        public int User_ID { get; set; }

        public User user { get; set; } // Navigation property
        public ICollection<Order_Item> order_Items { get; set; }
    }
}
