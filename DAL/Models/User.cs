using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class User
    {
        

        public int Id { get; set; }
        public string User_Name { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public ICollection<AddToCart> addToCarts { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<UserRole> userRoles { get; set; }

    }
}
