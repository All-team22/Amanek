using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public PaymentFrequency MaintenanceSchedule { get; set; }
        public int CompanyId { get; set; }
        public InsuranceCompany Company { get; set; }
    }

    public enum PaymentFrequency
    {
        Monthly,
        Quartely,
        Half,
        Yearly
    }
    public enum MaintenanceSchedule
    {
        Quartely,
        Half,
        Yearly
    }
}
