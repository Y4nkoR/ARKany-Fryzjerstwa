using System.ComponentModel.DataAnnotations;

namespace ARKanyFryzjerstwa.Models
{
    public class RegisterSalonModel : ModelWithIdentityErrorBase
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(450, ErrorMessage = "Maksymalna długość to 450 znaków.")]
        public string SalonName { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [Phone(ErrorMessage = "Numer telefonu ma niepoprawny format.")]
        public string SalonPhoneNumber { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(200, ErrorMessage = "Maksymalna długość to 200 znaków.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(200, ErrorMessage = "Maksymalna długość to 200 znaków.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(256, ErrorMessage = "Maksymalna długość to 256 znaków.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [StringLength(256, ErrorMessage = "Maksymalna długość to 256 znaków.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Wprowadzone hasła są różne.")]
        public string ConfirmPassword { get; set; }
        
    }
}
