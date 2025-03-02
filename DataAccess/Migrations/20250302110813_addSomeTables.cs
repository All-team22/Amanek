using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addSomeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InsurancePackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PolicyPrice = table.Column<double>(type: "float", nullable: false),
                    PaymentFrequency = table.Column<int>(type: "int", nullable: false),
                    MaintenanceSchedule = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePackages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsurancePackages_InsuranceCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserIDExpirationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserBirthDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LicenseIssuanceDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LicenseEndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<int>(type: "int", nullable: false),
                    MedicalCondition = table.Column<int>(type: "int", nullable: false),
                    MedicalCondComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergiesStatus = table.Column<int>(type: "int", nullable: false),
                    SmokingStatus = table.Column<int>(type: "int", nullable: false),
                    EducationLevel = table.Column<int>(type: "int", nullable: false),
                    EmploymentStatus = table.Column<int>(type: "int", nullable: false),
                    DriveJobPart = table.Column<int>(type: "int", nullable: false),
                    LicenseDegree = table.Column<int>(type: "int", nullable: false),
                    TravelStatus = table.Column<int>(type: "int", nullable: false),
                    DrivingAccident = table.Column<int>(type: "int", nullable: false),
                    CarBrand = table.Column<int>(type: "int", nullable: false),
                    CarManufacturingYear = table.Column<int>(type: "int", nullable: false),
                    CarPrice = table.Column<double>(type: "float", nullable: false),
                    EstimatedAnnualMileage = table.Column<double>(type: "float", nullable: false),
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParkingLocation = table.Column<int>(type: "int", nullable: false),
                    SecurityFeatures = table.Column<int>(type: "int", nullable: false),
                    InsuranceType = table.Column<int>(type: "int", nullable: false),
                    CoverageAmount = table.Column<double>(type: "float", nullable: false),
                    AdditionalCoverage = table.Column<int>(type: "int", nullable: false),
                    ImgUrls = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Banks = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePolicies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_InsuranceCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsurancePolicies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PolicyId = table.Column<int>(type: "int", nullable: false),
                    AccidentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccidentTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Photos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsurancePolicyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Claims_InsuranceCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Claims_InsurancePolicies_InsurancePolicyId",
                        column: x => x.InsurancePolicyId,
                        principalTable: "InsurancePolicies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Claims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Claims_CompanyId",
                table: "Claims",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_InsurancePolicyId",
                table: "Claims",
                column: "InsurancePolicyId");

            migrationBuilder.CreateIndex(
                name: "IX_Claims_UserId",
                table: "Claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePackages_CompanyId",
                table: "InsurancePackages",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_CompanyId",
                table: "InsurancePolicies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_UserId",
                table: "InsurancePolicies",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "InsurancePackages");

            migrationBuilder.DropTable(
                name: "InsurancePolicies");
        }
    }
}
