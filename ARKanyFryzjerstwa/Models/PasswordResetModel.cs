using System.ComponentModel.DataAnnotations;

namespace ARKanyFryzjerstwa.Models
{
    public class PasswordResetModel : ModelWithIdentityErrorBase
    {
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Login { get; set; }

        [Required(ErrorMessage ="Pole jest wymagane")]
        [MinLength(8, ErrorMessage ="Błędny kod")]
        [MaxLength(8, ErrorMessage = "Błędny kod")]
        [RegularExpression("^[A-Z0-9]{8}$", ErrorMessage = "Błędny kod")]
        public string VerificationCode { get; set; }


        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Hałsło musi zawierać min. 6 zaków. W tym cyfry, małe i wielkie litery oraz znaki specjalne")]
        [RegularExpression(@"^(?=.*?[0-9])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^\\p{L}0-9]).{6,}$", ErrorMessage = "Hałsło musi zawierać min. 6 zaków. W tym cyfry, małe i wielkie litery oraz znaki specjalne")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Pole jest wymagane")]
        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword), ErrorMessage = "Wprowadzone hasła są różne")]
        public string ConfirmNewPassword { get; set; }

        public bool ShowPasswordDetials { get; set; } = false;
        public DateTime RequestDateTime { get; set; }
    }
}
