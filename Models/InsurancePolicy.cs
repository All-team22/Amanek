using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class InsurancePolicy
    {
        public int Id { get; set; }

        // Personal Information 
        [Required]
        [StringLength(14)] // Max length for identification number
        public string UserIdentificationNumber { get; set; }

        [Required]
        public DateOnly UserIDExpirationDate { get; set; }

        // Health Information
        [Required]
        public BloodType BloodType { get; set; }

        public MedicalCondition MedicalCondition { get; set; }

        [StringLength(500)] // Optional field, with a max length
        public string? MedicalCondComment { get; set; }

        [Required]
        public AllergiesStatus AllergiesStatus { get; set; }

        [Required]
        public SmokingStatus SmokingStatus { get; set; }

        // Driving License
        [Required]
        [StringLength(15)] // Max length for license number
        public string LicenseNumber { get; set; }

        [Required]
        public LicenseDegree LicenseDegree { get; set; }

        [Required]
        public TravelStatus TravelStatus { get; set; }

        [Required]
        public DrivingAccident DrivingAccident { get; set; }

        [Required]
        public DateOnly LicenseIssuanceDate { get; set; }

        [Required]
        public DateOnly LicenseEndDate { get; set; }

        // Car Details
        [Required]
        public CarBrand CarBrand { get; set; }

        [Required]
        public CarManufacturingYear CarManufacturingYear { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Car price must be a positive value.")]
        public double CarPrice { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Estimated annual mileage must be a positive value.")]
        public double EstimatedAnnualMileage { get; set; }

        [Required]
        [StringLength(20)] // Max length for license plate
        public string LicensePlateNumber { get; set; }
        [Required]
        public ParkingLocation ParkingLocation { get; set; }

        [Required]
        public SecurityFeatures SecurityFeatures { get; set; }

        [Required]
        public VehicleUse VehicleUse { get; set; }

        [Required]
        public CompanyCarRental CompanyCarRental { get; set; }

        [Required]
        public DriverCarRental DriverCarRental { get; set; }

        // Insurance Options
        [Required]
        public InsuranceType InsuranceType { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Coverage amount must be a positive value.")]
        public double CoverageAmount { get; set; }

        [Required]
        public AdditionalCoverage AdditionalCoverage { get; set; }

        // Uploaded Documents
        [ValidateNever]
        public string? UserDocs { get; set; }

        // Bank Information
        [Required]
        public Banks Banks { get; set; }

        [Required]
        [StringLength(20)] // Max length for bank account number
        public string BankAccountNumber { get; set; }

        // Acknowledgement
        [Required]
        public UserAcknowledgement UserAcknowledgement { get; set; }

        // Policy Status
        public PolicyStatus PolicyStatus { get; set; } = PolicyStatus.Pending;
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser User { get; set; }

        public int CompanyId { get; set; }
        [ValidateNever]
        public InsuranceCompany Company { get; set; }
        public int packageId { get; set; }
        [ValidateNever]
        public InsurancePackage Package { get; set; }

        public ICollection<Claim> Claims { get; set; } = new List<Claim>();
    }

    // Enums used in properties only

    public enum CarManufacturingYear
    {
        Year2025 = 2025,
        Year2024 = 2024,
        Year2023 = 2023,
        Year2022 = 2022,
        Year2021 = 2021,
        Year2020 = 2020,
        Year2019 = 2019,
        Year2018 = 2018
    }

    public enum DrivingAccident { Yes, No }
    public enum SmokingStatus { Yes, No }
    public enum AllergiesStatus { Yes, No }
    public enum TravelStatus { Yes, No }
    public enum CompanyCarRental { Yes, No }
    public enum DriverCarRental { Yes, No }
    public enum UserAcknowledgement { Yes, No }

    public enum CarBrand
    {
        Toyota, Honda, Ford, BMW, Mercedes, Nissan, Chevrolet, Hyundai
    }

    public enum ParkingLocation
    {
        Garage, Driveway, StreetParking, SecuredParkingLot
    }

    [Flags]
    public enum SecurityFeatures
    {
        AntiTheftSystem = 1,
        GPSTracker = 2,
        Dashcam = 4,
        Airbags = 8,
        ABSBrakes = 16
    }

    public enum BloodType
    {
        O_Positive, O_Negative, A_Positive, A_Negative, B_Positive, B_Negative, AB_Positive, AB_Negative
    }

    public enum MedicalCondition
    {
        Diabetes, HeartDisease, Asthma, Hypertension, Arthritis, Cancer, KidneyDisease, LiverDisease
    }

    public enum LicenseDegree
    {
        LearnersPermit, StandardLicense, CommercialLicense, HeavyVehicleLicense
    }

    public enum Banks
    {
        NBE, CIB, Masr, Suez, Alex, Cairo
    }

    public enum InsuranceType
    {
        Comprehensive, ThirdPartyLiability, CollisionCoverage, PersonalInjuryProtection, UninsuredMotoristCoverage
    }

    [Flags]
    public enum AdditionalCoverage
    {
        RoadsideAssistance = 1,
        RentalCarReimbursement = 2,
        GlassCoverage = 4
    }

    public enum PolicyStatus
    {
        Accepted, Rejected, Pending
    }

    public enum VehicleUse
    {
        PersonalUse,
        CommercialUse,
        Taxi,
        Delivery,
        Transportation
    }
}
