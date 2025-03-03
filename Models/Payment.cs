using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Models
{
    public class Payment
    {
        public int Id { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

        [Required]
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
         
        public int InsuranceCompanyId { get; set; }
        [ForeignKey("InsuranceCompanyId")]
        [ValidateNever]
        public InsuranceCompany InsuranceCompany { get; set; }
        public int InsurancePolicyId { get; set; }
        [ForeignKey("InsurancePolicyId")]
        [ValidateNever]
        public InsurancePolicy InsurancePolicy { get; set; }

        public int? ClaimId { get; set; }
        [ForeignKey("ClaimId")]
        [ValidateNever]
        public Claim? Claim { get; set; }

      
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }


    }
    public enum PaymentStatus
    {
        Success,
        Failed,
        Pending
    }

}
