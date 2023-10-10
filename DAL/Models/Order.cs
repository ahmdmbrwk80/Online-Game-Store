using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceGame.DAL.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceGame.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public int User_ID { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public int TotalPrice { get; set; }
        public User user { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public List<Order_Item> Order_Item { get; set; }
    }
}

