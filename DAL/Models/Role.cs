using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<UserRole> userRoles { get; set; }
    }
}
