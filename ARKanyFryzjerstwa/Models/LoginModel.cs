using System.ComponentModel.DataAnnotations;

namespace ARKanyFryzjerstwa.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Pole jest wymagane.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
