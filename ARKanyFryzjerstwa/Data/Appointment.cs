using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    public enum AppointmentStatus
    {
        Scheduled,
        Canceled,
        Completed
    }

    [Table("Appointments")]
    public class Appointment
    {
        [Key]
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        [StringLength(450)]
        public string EmployeeId { get; set; }

        [StringLength(450)]
        public string? AuthorId { get; set; }

        public int ServiceId { get; set; }

        public int? ClientId { get; set; }

        public AppointmentStatus Status { get; set; }
        public decimal? StandardPrice { get; set; }
        public decimal? FinalPrice { get; set; }
    }
}
