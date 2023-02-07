using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rpg_api.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleID { get; set; }

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(200)]
        public string? Address { get; set; }

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string? City { get; set; }

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string? State { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public string Phone { get; set; } = null!;

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(30)]
        public string Email { get; set; } = null!;

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string? AdvisorID { get; set; }

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string? AgentID { get; set; }

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(6)]
        public string? ClientID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string LastName { get; set; } = null!;

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string FirstName { get; set; } = null!;

        
        [Column(TypeName = "VARCHAR")]
        [StringLength(150)]
        public string? Company { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string SortName { get; private set; } = null!;

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
        public bool DeletedFlag { get; set; }
    }
}
