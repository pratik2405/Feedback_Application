using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingRound.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string ? Email { get; set; }

        [Required]
        public string ? PasswordHash { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "This field is required !")]
        [Compare("PasswordHash", ErrorMessage = "Password can't be match !")]
        public string ? PasswordConfirm { get; set; }
    }
}
