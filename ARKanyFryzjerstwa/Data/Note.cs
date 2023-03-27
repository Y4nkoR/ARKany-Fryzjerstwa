using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    [Table("Notes")]
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        [MaxLength(4000)]
        public string Text { get; set; }
    }
}
