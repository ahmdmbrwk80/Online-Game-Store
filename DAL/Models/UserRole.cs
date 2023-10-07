using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class UserRole
    {
        public int User_Id { get; set; }
        public User user { get; set; } // Navigation property
        public int Role_ID { get; set; }
        public Role role { get; set; } // Navigation property
    }
}
