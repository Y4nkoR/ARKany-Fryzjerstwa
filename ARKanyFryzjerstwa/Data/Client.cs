using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    [Table("Clients")]
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [StringLength(200)]
        public string? Email { get; set; }

        [ForeignKey("ClientId")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        [ForeignKey("ClientId")]
        public virtual ICollection<ClientSalon> ClientSalons { get; set; }
    }
}
