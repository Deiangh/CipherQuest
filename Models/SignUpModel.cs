using System.ComponentModel.DataAnnotations;

namespace Experiments.Models
{
    public class SignUpModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(32, ErrorMessage = "Password must be at least 6 characters and less than 32.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(32, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters and less than 32.")]
        public string password { get; set; }
    }
}
