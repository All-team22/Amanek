﻿// <auto-generated />
using System;
using Data_Access;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", (string)null);
                });

            modelBuilder.Entity("Models.Claim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AccidentDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("AccidentTime")
                        .HasColumnType("time");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("InsurancePolicyId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolicyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("InsurancePolicyId");

                    b.HasIndex("UserId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("Models.InsuranceCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("InsuranceCompanies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cairo, Egypt",
                            ContactEmail = "info@misrinsurance.com",
                            Location = "Cairo",
                            Name = "Misr Insurance",
                            Phone = "+20 2 2399 9400",
                            RegistrationNumber = "10001",
                            Website = "https://www.misrins.com.eg"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Alexandria, Egypt",
                            ContactEmail = "support@sci-egypt.com",
                            Location = "Alexandria",
                            Name = "Suez Canal Insurance",
                            Phone = "+20 3 4849 520",
                            RegistrationNumber = "10002",
                            Website = "https://www.sci-egypt.com"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Giza, Egypt",
                            ContactEmail = "contact@gig-egypt.com",
                            Location = "Giza",
                            Name = "GIG Egypt",
                            Phone = "+20 2 3749 1181",
                            RegistrationNumber = "10003",
                            Website = "https://www.gig-egypt.com"
                        },
                        new
                        {
                            Id = 4,
                            Address = "New Cairo, Egypt",
                            ContactEmail = "info@allianz.com.eg",
                            Location = "New Cairo",
                            Name = "Allianz Egypt",
                            Phone = "+20 2 2260 7000",
                            RegistrationNumber = "10004",
                            Website = "https://www.allianz.com.eg"
                        },
                        new
                        {
                            Id = 5,
                            Address = "Nasr City, Egypt",
                            ContactEmail = "service@royalinsurance.com.eg",
                            Location = "Nasr City",
                            Name = "Royal Insurance",
                            Phone = "+20 2 2271 8444",
                            RegistrationNumber = "10005",
                            Website = "https://www.royalinsurance.com.eg"
                        });
                });

            modelBuilder.Entity("Models.InsurancePackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarEndModels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("CarMaxPrice")
                        .HasColumnType("float");

                    b.Property<double?>("CarMinPrice")
                        .HasColumnType("float");

                    b.Property<string>("CarStartModels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaintenanceSchedule")
                        .HasColumnType("int");

                    b.Property<string>("PackageName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PaymentFrequency")
                        .HasColumnType("int");

                    b.Property<double>("PolicyPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("InsurancePackages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 2,
                            PackageName = "Basic Plan",
                            PaymentFrequency = 0,
                            PolicyPrice = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 1,
                            PackageName = "Premium Plan",
                            PaymentFrequency = 1,
                            PolicyPrice = 2500.0
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 0,
                            PackageName = "Pro Plan",
                            PaymentFrequency = 3,
                            PolicyPrice = 4000.0
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 2,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 1,
                            PackageName = "Silver Package",
                            PaymentFrequency = 0,
                            PolicyPrice = 1200.0
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 2,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 2,
                            PackageName = "Gold Package",
                            PaymentFrequency = 1,
                            PolicyPrice = 2800.0
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 2,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 0,
                            PackageName = "Platinum Package",
                            PaymentFrequency = 3,
                            PolicyPrice = 5000.0
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 3,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 1,
                            PackageName = "Starter Plan",
                            PaymentFrequency = 0,
                            PolicyPrice = 800.0
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 3,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 2,
                            PackageName = "Family Plan",
                            PaymentFrequency = 1,
                            PolicyPrice = 3000.0
                        },
                        new
                        {
                            Id = 9,
                            CompanyId = 3,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 0,
                            PackageName = "Elite Plan",
                            PaymentFrequency = 3,
                            PolicyPrice = 5500.0
                        },
                        new
                        {
                            Id = 10,
                            CompanyId = 4,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 1,
                            PackageName = "Standard Cover",
                            PaymentFrequency = 0,
                            PolicyPrice = 1500.0
                        },
                        new
                        {
                            Id = 11,
                            CompanyId = 4,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 2,
                            PackageName = "Advanced Cover",
                            PaymentFrequency = 1,
                            PolicyPrice = 3200.0
                        },
                        new
                        {
                            Id = 12,
                            CompanyId = 4,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 0,
                            PackageName = "Executive Cover",
                            PaymentFrequency = 3,
                            PolicyPrice = 6000.0
                        },
                        new
                        {
                            Id = 13,
                            CompanyId = 5,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 1,
                            PackageName = "Basic Shield",
                            PaymentFrequency = 0,
                            PolicyPrice = 900.0
                        },
                        new
                        {
                            Id = 14,
                            CompanyId = 5,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 2,
                            PackageName = "Comprehensive Shield",
                            PaymentFrequency = 1,
                            PolicyPrice = 3500.0
                        },
                        new
                        {
                            Id = 15,
                            CompanyId = 5,
                            CreatedBy = "Company",
                            MaintenanceSchedule = 0,
                            PackageName = "Ultimate Shield",
                            PaymentFrequency = 3,
                            PolicyPrice = 7000.0
                        });
                });

            modelBuilder.Entity("Models.InsurancePolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdditionalCoverage")
                        .HasColumnType("int");

                    b.Property<int>("AllergiesStatus")
                        .HasColumnType("int");

                    b.Property<string>("BankAccountNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Banks")
                        .HasColumnType("int");

                    b.Property<int>("BloodType")
                        .HasColumnType("int");

                    b.Property<int>("CarBrand")
                        .HasColumnType("int");

                    b.Property<int>("CarManufacturingYear")
                        .HasColumnType("int");

                    b.Property<double>("CarPrice")
                        .HasColumnType("float");

                    b.Property<int>("CompanyCarRental")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double>("CoverageAmount")
                        .HasColumnType("float");

                    b.Property<int>("DriverCarRental")
                        .HasColumnType("int");

                    b.Property<int>("DrivingAccident")
                        .HasColumnType("int");

                    b.Property<double>("EstimatedAnnualMileage")
                        .HasColumnType("float");

                    b.Property<int?>("InsurancePackageId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceType")
                        .HasColumnType("int");

                    b.Property<int>("LicenseDegree")
                        .HasColumnType("int");

                    b.Property<DateOnly>("LicenseEndDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("LicenseIssuanceDate")
                        .HasColumnType("date");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LicensePlateNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MedicalCondComment")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("MedicalCondition")
                        .HasColumnType("int");

                    b.Property<int>("ParkingLocation")
                        .HasColumnType("int");

                    b.Property<int>("PolicyStatus")
                        .HasColumnType("int");

                    b.Property<int>("SecurityFeatures")
                        .HasColumnType("int");

                    b.Property<int>("SmokingStatus")
                        .HasColumnType("int");

                    b.Property<int>("TravelStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserAcknowledgement")
                        .HasColumnType("int");

                    b.Property<string>("UserDocs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("UserIDExpirationDate")
                        .HasColumnType("date");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserIdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int>("VehicleUse")
                        .HasColumnType("int");

                    b.Property<int>("packageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("InsurancePackageId");

                    b.HasIndex("UserId");

                    b.HasIndex("packageId");

                    b.ToTable("InsurancePolicies");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ClaimId")
                        .HasColumnType("int");

                    b.Property<int>("InsuranceCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("InsurancePolicyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ClaimId");

                    b.HasIndex("InsuranceCompanyId");

                    b.HasIndex("InsurancePolicyId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.HasIndex("CompanyId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Claim", b =>
                {
                    b.HasOne("Models.InsuranceCompany", "Company")
                        .WithMany("Claim")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.InsurancePolicy", null)
                        .WithMany("Claims")
                        .HasForeignKey("InsurancePolicyId");

                    b.HasOne("Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.InsurancePackage", b =>
                {
                    b.HasOne("Models.InsuranceCompany", "Company")
                        .WithMany("Packages")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Models.InsurancePolicy", b =>
                {
                    b.HasOne("Models.InsuranceCompany", "Company")
                        .WithMany("Policy")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.InsurancePackage", null)
                        .WithMany("Policies")
                        .HasForeignKey("InsurancePackageId");

                    b.HasOne("Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.InsurancePackage", "Package")
                        .WithMany()
                        .HasForeignKey("packageId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Package");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.HasOne("Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Models.Claim", "Claim")
                        .WithMany()
                        .HasForeignKey("ClaimId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Models.InsuranceCompany", "InsuranceCompany")
                        .WithMany()
                        .HasForeignKey("InsuranceCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.InsurancePolicy", "InsurancePolicy")
                        .WithMany()
                        .HasForeignKey("InsurancePolicyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Claim");

                    b.Navigation("InsuranceCompany");

                    b.Navigation("InsurancePolicy");
                });

            modelBuilder.Entity("Models.ApplicationUser", b =>
                {
                    b.HasOne("Models.InsuranceCompany", "InsuranceCompany")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.Navigation("InsuranceCompany");
                });

            modelBuilder.Entity("Models.InsuranceCompany", b =>
                {
                    b.Navigation("Claim");

                    b.Navigation("Packages");

                    b.Navigation("Policy");
                });

            modelBuilder.Entity("Models.InsurancePackage", b =>
                {
                    b.Navigation("Policies");
                });

            modelBuilder.Entity("Models.InsurancePolicy", b =>
                {
                    b.Navigation("Claims");
                });
#pragma warning restore 612, 618
        }
    }
}
