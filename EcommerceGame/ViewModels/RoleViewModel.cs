using EcommerceGame.DAL.Models;

namespace EcommerceGame.PL.ViewModels
{
    public class RoleViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<UserRole> userRoles { get; set; }
    }
}
