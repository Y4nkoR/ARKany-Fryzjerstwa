using System.ComponentModel.DataAnnotations;

namespace ARKanyFryzjerstwa.Models
{
    public class AppointmentAddModel
    {
        [Required]
        [StringLength(200)]
        public string Client { get; set; }
        
        [StringLength(11, MinimumLength = 9)]
        public string? PhoneNumber { get; set; }

        [StringLength(200)]
        public string? Email { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string StartTime { get; set; }

        public string? EndTime { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [StringLength(450)]
        public string EmployeeId { get; set; }

        public bool IsAnonymous { get; set; }
    }
}
