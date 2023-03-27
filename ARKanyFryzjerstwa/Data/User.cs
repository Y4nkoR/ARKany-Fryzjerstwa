using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    public class User : IdentityUser
    {
        [Required]
        public int SalonId { get; set; }
        public bool IsActive { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(7)]
        public string Color { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual ICollection<Appointment> EmployeeAppointments { get; set; }

        [ForeignKey("AuthorId")]
        public virtual ICollection<Appointment> CreatedAppointments { get; set; }
    }
}
