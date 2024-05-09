using System.ComponentModel.DataAnnotations;

namespace Experiments.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Username is required.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string password { get; set; }
    }
}
