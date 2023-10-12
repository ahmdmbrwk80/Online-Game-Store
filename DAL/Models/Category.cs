using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models
{
   
    public  class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string CategoryName { get; set; }
        public List<Game> Games { get; set; }
    }
}
