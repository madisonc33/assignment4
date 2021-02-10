using System;
using System.ComponentModel.DataAnnotations;
namespace assignment4.Models
{
    public class Suggestions
    {
        public string Name { get; set; }

        [Required]
        public string RestName { get; set; }

        public string FavDish { get; set; }

        //Regular expression that makes sure the number has 9 numbers and will except dashes, parenthesis and spaces
        [Phone]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

    }
}
