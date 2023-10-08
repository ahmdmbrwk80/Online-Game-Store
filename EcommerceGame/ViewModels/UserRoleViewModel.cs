using EcommerceGame.DAL.Models;

namespace EcommerceGame.PL.ViewModels
{
    public class UserRoleViewModel
    {
        public int User_Id { get; set; }
        public User user { get; set; } // Navigation property
        public int Role_ID { get; set; }
        public Role role { get; set; } // Navigation property
    }
}
