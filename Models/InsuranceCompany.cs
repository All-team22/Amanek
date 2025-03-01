using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class InsuranceCompany
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [StringLength(100, ErrorMessage = "Company Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Registration number is required")]
        [StringLength(50, ErrorMessage = "Registration number cannot exceed 50 characters")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location cannot exceed 100 characters")]
        public string Location { get; set; }
        public string? Website { get; set; }

        [ValidateNever]
        public string? Logo { get; set; }
        public List<InsurancePolicy> Policy { get; set; }   = new List<InsurancePolicy>();
        public List<InsurancePackage> Packages { get; set; } = new List<InsurancePackage>();
        public List<Claim> Claim { get; set; } = new List<Claim>();
    }
}
