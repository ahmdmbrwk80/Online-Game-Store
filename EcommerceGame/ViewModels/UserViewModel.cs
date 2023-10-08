using EcommerceGame.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace EcommerceGame.PL.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required]

        public string User_Name { get; set; }
        [Required]

        public string PassWord { get; set; }
        [EmailAddress]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Invalid email address")]
        //        ^                  # Start of the string
        //\w+                # Match one or more word characters (letters, digits, or underscores)
        //([-+.']\w+)*       # Match optional characters like ' - ', ' + ', '.', or ''' followed by one or more word characters, repeated zero or more times
        //@                  # Match the '@' symbol
        //\w +                # Match one or more word characters (letters, digits, or underscores)
        //([-.]\w +)*         # Match optional characters like '-', '.', or '_', followed by one or more word characters, repeated zero or more times
        //\.\w +              # Match a period followed by one or more word characters (the domain extension)
        //([-.]\w +)*         # Match optional characters like '-', '.', or '_', followed by one or more word characters, repeated zero or more times
        //$                  # End of the string
        // the valid email lika "john.doe@example.com" or "user-name@example.com".
        public string Email { get; set; }
        [Range(15, 55)]
        public int Age { get; set; }
        public ICollection<AddToCart> addToCarts { get; set; }
        public ICollection<Order> orders { get; set; }
        public ICollection<UserRole> userRoles { get; set; }
    }
}
