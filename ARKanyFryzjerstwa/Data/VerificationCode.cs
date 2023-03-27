using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ARKanyFryzjerstwa.Data
{
    [Table("VerificationCodes")]
    public class VerificationCode
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8)]
        public string Code { get; set; }

        [StringLength(450)]
        public string UserId { get; set; }

        public DateTime InsertDateTime { get; set; }

        public bool IsUsed { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
