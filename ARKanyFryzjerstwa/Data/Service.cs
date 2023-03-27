using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    [Table("Services")]
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public int SalonId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual ICollection<ServiceResource> ServiceResources { get; set; }
    }
}
