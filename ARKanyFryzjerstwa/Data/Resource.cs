using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    public enum ResourceUnit
    {
        [Description("ml")]
        Ml,
        [Description("szt")]
        Szt,
    }

    [Table("Resources")]
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        public int SalonId { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public float Quantity { get; set; }
        public ResourceUnit Unit { get; set; }
        [Column("Usage")]
        public float AlertQuantity { get; set; }

        public virtual ICollection<ServiceResource> ServiceResources { get; set; }
    }
}
