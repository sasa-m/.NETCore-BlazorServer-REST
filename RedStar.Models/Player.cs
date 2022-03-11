using System.ComponentModel.DataAnnotations;

namespace RedStar.Models
{
    public class Player
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        public string Position { get; set; }

        public int Height { get; set; }

        public int Born { get; set; }

        public string PhotoPath { get; set; }
    }
}
