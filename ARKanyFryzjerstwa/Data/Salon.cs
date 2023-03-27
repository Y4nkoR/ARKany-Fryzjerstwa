using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    [Table("Salons")]
    public class Salon
    {
        [Key]
        public int Id { get; set; }

        [StringLength(450)]
        public string Name { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [ForeignKey("SalonId")]
        public virtual ICollection<Resource> Resources { get; set; }

        [ForeignKey("SalonId")]
        public virtual ICollection<Service> Services { get; set; }

        [ForeignKey("SalonId")]
        public virtual ICollection<User> Employees { get; set; }

        [ForeignKey("SalonId")]
        public virtual ICollection<ClientSalon> SalonClients { get; set; }
    }
}
