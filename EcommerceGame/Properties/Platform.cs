using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class Platform
    {
        public string Name { get; set; }
        public int Game_ID { get; set; }
        public Game game { get; set; } // Navigation property

    }
}
