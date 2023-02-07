using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rpg_api.Models
{
    public class InvestorInfo
    {
        [Key]
        public int InvestorInfoID { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int UserID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string? InvestmentName { get; set; }

        [Required]
        [Column(TypeName = "Tinyint")]
        public int Active { get; set; }

        [Required]
        [Column(TypeName = "DateTime2")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string? ModifiedBy { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public int DeletedFlag { get; set; }

        [NotMapped]
        public bool DeletedFlagbool
        {
            get { return (DeletedFlag == 1); }
        }
    }
}
