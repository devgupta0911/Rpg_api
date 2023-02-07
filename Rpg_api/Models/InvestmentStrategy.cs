using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rpg_api.Models
{
    public class InvestmentStrategy
    {
        [Key]
        public int InvestmentStrategyID { get; set; }

        [Required]
        [ForeignKey("InvestorInfo")]
        public int InvestorInfoID { get;}

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string StrategyName { get; set; } = null!;

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string AccountId { get; set; }= null!;

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string ModelAPLID { get; set; } = null!;

        [Required]
        [Column(TypeName ="decimal(17,5)")]
        public decimal InvestmentAmount { get; set; }

        [Required]
        [ForeignKey("InvestmentType")]
        public int InvestmentTypeID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string? ModifiedBy { get; set; }

        [Column(TypeName = "DateTime2")]
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public bool DeletedFlag { get; set; }









    }
}
