using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Routing.Constraints;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Models
{
    public class InsurancePackage
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Package Name is required")]
        [StringLength(100, ErrorMessage = "Package Name cannot exceed 100 characters")]
        public string PackageName { get; set; }

        [Required(ErrorMessage = "Policy Price is required")]
        [Range(0, double.MaxValue, ErrorMessage = "Policy Price must be a positive number")]
        public double PolicyPrice { get; set; }

        [Required(ErrorMessage = "Payment Frequency is required")]
        public PaymentFrequency PaymentFrequency { get; set; }

        [Required(ErrorMessage = "Maintenance Schedule is required")]
        public MaintenanceSchedule MaintenanceSchedule { get; set; }
        public int? CarStartModels { get; set; }
        public int? CarEndModels { get; set; }
        public double? CarMinPrice { get; set; }
        public double? CarMaxPrice { get; set; }
        public string CreatedBy { get; set; } = SD.AdminRole;
        public int CompanyId { get; set; }
        [ValidateNever]
        public InsuranceCompany Company { get; set; }
        [ValidateNever]
        public List<InsurancePolicy> Policies { get; set; } = new List<InsurancePolicy>();
    }

    public enum PaymentFrequency
    {
        Monthly,
        Quarterly,
        Half,
        Yearly
    }
    public enum MaintenanceSchedule
    {
        Quarterly,
        Half,
        Yearly
    }
}
