using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rpg_api.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string RoleName { get; set; } = null!;

        [Required]
        [Column(TypeName = "Tinyint")]
        public int Active { get; set; }
    }
}
