using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser User { get; set; }   
        public int CompanyId { get; set; }
        [ValidateNever]
        public InsuranceCompany Company { get; set; }
        [ValidateNever]
        public int PolicyId { get; set; }
        public InsurancePolicy Policy { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Accident Date")]
        public DateTime AccidentDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Accident Time")]
        public TimeSpan AccidentTime { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Display(Name = "Photos")]
        public List<string> ? Photos { get; set; } = new List<string>();
    }
}
