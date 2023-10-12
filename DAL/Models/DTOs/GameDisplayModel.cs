using Humanizer.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceGame.DAL.Models.DTOs
{
    public class GameDisplayModel
    {
        public IEnumerable<Game> Games { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string STerm { get; set; } = "";
        public int CategoryId { get; set; } = 0;
    }
}
