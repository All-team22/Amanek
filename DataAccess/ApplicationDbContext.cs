using Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;
using Utility;

namespace Data_Access
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<InsurancePackage> InsurancePackages { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Payment> payments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Claim>()
            //    .HasOne(c => c.Policy)  
            //    .WithMany(p => p.Claims)
            //    .HasForeignKey(c => c.PolicyId)
            //    .OnDelete(DeleteBehavior.Cascade);
            builder.Entity<InsurancePolicy>()
    .HasOne(ip => ip.Package) 
    .WithMany()
    .HasForeignKey(ip => ip.packageId)
    .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<InsuranceCompany>().HasData(
                    new InsuranceCompany { Id = 1, Name = "Misr Insurance", RegistrationNumber = "10001", Address = "Cairo, Egypt", ContactEmail = "info@misrinsurance.com", Phone = "+20 2 2399 9400", Location = "Cairo", Website = "https://www.misrins.com.eg", Logo = null },
                    new InsuranceCompany { Id = 2, Name = "Suez Canal Insurance", RegistrationNumber = "10002", Address = "Alexandria, Egypt", ContactEmail = "support@sci-egypt.com", Phone = "+20 3 4849 520", Location = "Alexandria", Website = "https://www.sci-egypt.com", Logo = null },
                    new InsuranceCompany { Id = 3, Name = "GIG Egypt", RegistrationNumber = "10003", Address = "Giza, Egypt", ContactEmail = "contact@gig-egypt.com", Phone = "+20 2 3749 1181", Location = "Giza", Website = "https://www.gig-egypt.com", Logo = null },
                    new InsuranceCompany { Id = 4, Name = "Allianz Egypt", RegistrationNumber = "10004", Address = "New Cairo, Egypt", ContactEmail = "info@allianz.com.eg", Phone = "+20 2 2260 7000", Location = "New Cairo", Website = "https://www.allianz.com.eg", Logo = null },
                    new InsuranceCompany { Id = 5, Name = "Royal Insurance", RegistrationNumber = "10005", Address = "Nasr City, Egypt", ContactEmail = "service@royalinsurance.com.eg", Phone = "+20 2 2271 8444", Location = "Nasr City", Website = "https://www.royalinsurance.com.eg", Logo = null }
            );
            // Seed Insurance Packages (3 per company)
            builder.Entity<InsurancePackage>().HasData(
                // Packages for Misr Insurance
                new InsurancePackage { Id = 1, PackageName = "Basic Plan", PolicyPrice = 1000, PaymentFrequency = PaymentFrequency.Monthly, MaintenanceSchedule = MaintenanceSchedule.Yearly, CreatedBy = SD.CompanyRole, CompanyId = 1 },
                new InsurancePackage { Id = 2, PackageName = "Premium Plan", PolicyPrice = 2500, PaymentFrequency = PaymentFrequency.Quarterly, MaintenanceSchedule = MaintenanceSchedule.Half, CreatedBy = SD.CompanyRole, CompanyId = 1 },
                new InsurancePackage { Id = 3, PackageName = "Pro Plan", PolicyPrice = 4000, PaymentFrequency = PaymentFrequency.Yearly, MaintenanceSchedule = MaintenanceSchedule.Quarterly, CreatedBy = SD.CompanyRole, CompanyId = 1 },

                // Packages for Suez Canal Insurance
                new InsurancePackage { Id = 4, PackageName = "Silver Package", PolicyPrice = 1200, PaymentFrequency = PaymentFrequency.Monthly, MaintenanceSchedule = MaintenanceSchedule.Half, CreatedBy = SD.CompanyRole, CompanyId = 2 },
                new InsurancePackage { Id = 5, PackageName = "Gold Package", PolicyPrice = 2800, PaymentFrequency = PaymentFrequency.Quarterly, MaintenanceSchedule = MaintenanceSchedule.Yearly, CreatedBy = SD.CompanyRole, CompanyId = 2 },
                new InsurancePackage { Id = 6, PackageName = "Platinum Package", PolicyPrice = 5000, PaymentFrequency = PaymentFrequency.Yearly, MaintenanceSchedule = MaintenanceSchedule.Quarterly, CreatedBy = SD.CompanyRole, CompanyId = 2 },

                // Packages for GIG Egypt
                new InsurancePackage { Id = 7, PackageName = "Starter Plan", PolicyPrice = 800, PaymentFrequency = PaymentFrequency.Monthly, MaintenanceSchedule = MaintenanceSchedule.Half, CreatedBy = SD.CompanyRole, CompanyId = 3 },
                new InsurancePackage { Id = 8, PackageName = "Family Plan", PolicyPrice = 3000, PaymentFrequency = PaymentFrequency.Quarterly, MaintenanceSchedule = MaintenanceSchedule.Yearly, CreatedBy = SD.CompanyRole, CompanyId = 3 },
                new InsurancePackage { Id = 9, PackageName = "Elite Plan", PolicyPrice = 5500, PaymentFrequency = PaymentFrequency.Yearly, MaintenanceSchedule = MaintenanceSchedule.Quarterly, CreatedBy = SD.CompanyRole, CompanyId = 3 },

                // Packages for Allianz Egypt
                new InsurancePackage { Id = 10, PackageName = "Standard Cover", PolicyPrice = 1500, PaymentFrequency = PaymentFrequency.Monthly, MaintenanceSchedule = MaintenanceSchedule.Half, CreatedBy = SD.CompanyRole, CompanyId = 4 },
                new InsurancePackage { Id = 11, PackageName = "Advanced Cover", PolicyPrice = 3200, PaymentFrequency = PaymentFrequency.Quarterly, MaintenanceSchedule = MaintenanceSchedule.Yearly, CreatedBy = SD.CompanyRole, CompanyId = 4 },
                new InsurancePackage { Id = 12, PackageName = "Executive Cover", PolicyPrice = 6000, PaymentFrequency = PaymentFrequency.Yearly, MaintenanceSchedule = MaintenanceSchedule.Quarterly, CreatedBy = SD.CompanyRole, CompanyId = 4 },

                // Packages for Royal Insurance
                new InsurancePackage { Id = 13, PackageName = "Basic Shield", PolicyPrice = 900, PaymentFrequency = PaymentFrequency.Monthly, MaintenanceSchedule = MaintenanceSchedule.Half, CreatedBy = SD.CompanyRole, CompanyId = 5 },
                new InsurancePackage { Id = 14, PackageName = "Comprehensive Shield", PolicyPrice = 3500, PaymentFrequency = PaymentFrequency.Quarterly, MaintenanceSchedule = MaintenanceSchedule.Yearly, CreatedBy = SD.CompanyRole, CompanyId = 5 },
                new InsurancePackage { Id = 15, PackageName = "Ultimate Shield", PolicyPrice = 7000, PaymentFrequency = PaymentFrequency.Yearly, MaintenanceSchedule = MaintenanceSchedule.Quarterly, CreatedBy = SD.CompanyRole, CompanyId = 5 }
            );

            builder.Entity<Payment>()
                .HasOne(p => p.InsurancePolicy)
                .WithMany()
                .HasForeignKey(p => p.InsurancePolicyId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Payment>()
                .HasOne(p => p.Claim)
                .WithMany()
                .HasForeignKey(p => p.ClaimId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Payment>()
                .HasOne(p => p.ApplicationUser)
                .WithMany()
                .HasForeignKey(p => p.ApplicationUserId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<IdentityUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
           
        }

    }
}
