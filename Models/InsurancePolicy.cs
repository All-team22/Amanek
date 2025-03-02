using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class InsurancePolicy
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; }
        public string? Role { get; set; }
        public string LicenseNumber { get; set; }
        public DateOnly UserIDExpirationDate { get; set; }
        public DateOnly UserBirthDate { get; set; }
        public DateOnly LicenseIssuanceDate { get; set; }
        public DateOnly LicenseEndDate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public BloodType BloodType { get; set; }
        public MedicalCondition MedicalCondition { get; set; }
        public string? MedicalCondComment { get; set; }
        public AllergiesStatus AllergiesStatus { get; set; }
        public SmokingStatus SmokingStatus { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public DriveJobPart DriveJobPart { get; set; }
        public LicenseDegree LicenseDegree { get; set; }
        public TravelStatus TravelStatus { get; set; }
        public DrivingAccident DrivingAccident { get; set; }
        public CarBrand CarBrand { get; set; }
        public CarManufacturingYear CarManufacturingYear { get; set; }
        public double CarPrice { get; set; }
        public double EstimatedAnnualMileage { get; set; }
        public string LicensePlateNumber { get; set; }
        public ParkingLocation ParkingLocation { get; set; }
        public SecurityFeatures SecurityFeatures { get; set; }
        public InsuranceType InsuranceType { get; set; }
        public double CoverageAmount { get; set; }
        public AdditionalCoverage AdditionalCoverage { get; set; }
        public List<string>? ImgUrls { get; set; }
        public Banks Banks { get; set; }
        public string AccountNumber { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser User { get; set; }

        public int CompanyId { get; set; }
        public InsuranceCompany Company { get; set; }
        public ICollection<Claim> Claims { get; set; } = new List<Claim>();
    }

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

    public enum MaritalStatus { Single, Divorced, Married, Widowed }
    public enum DrivingAccident { Yes, No }
    public enum Gender { Male, Female }
    public enum SmokingStatus { Yes, No }
    public enum AllergiesStatus { Yes, No }
    public enum TravelStatus { Yes, No }
    public enum DriveJobPart { Yes, No }

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

    public enum EducationLevel
    {
        NoFormalEducation, HighSchool, Diploma, BachelorsDegree, MastersDegree, DoctoratePhD
    }

    public enum EmploymentStatus
    {
        Employed, SelfEmployed, Unemployed, Retired, Student
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

    public enum AdditionalCoverage
    {
        RoadsideAssistance, RentalCarReimbursement, GlassCoverage
    }
}
