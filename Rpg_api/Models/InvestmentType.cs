﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rpg_api.Models
{
    public class InvestmentType
    {
        [Key]
        public int InvestmentTypeID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? InvestmentTypeName { get; set; }

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
        public bool DeletedFlagbool {
            get { return (DeletedFlag == 1); } 
        }
    }
}
