using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Identification Number is required.")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Identification Number must be exactly 14 characters.")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string FullName { get; set; } = null!;
        [Required]
        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string FullAddress { get; set; }
        public byte[]? ProfilePicture { get; set; }
        public int? CompanyId { get; set; }

        [ValidateNever]
        [ForeignKey("CompanyId")]
        public InsuranceCompany InsuranceCompany { get; set; }

        [NotMapped]
        public string Role { get; set; }
    }
}
