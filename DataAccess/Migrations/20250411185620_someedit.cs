using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class someedit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "DriveJobPart",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "ImgUrls",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "UserBirthDate",
                table: "InsurancePolicies");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "InsurancePolicies",
                newName: "UserDocs");

            migrationBuilder.RenameColumn(
                name: "MaritalStatus",
                table: "InsurancePolicies",
                newName: "VehicleUse");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "InsurancePolicies",
                newName: "UserAcknowledgement");

            migrationBuilder.RenameColumn(
                name: "EmploymentStatus",
                table: "InsurancePolicies",
                newName: "DriverCarRental");

            migrationBuilder.RenameColumn(
                name: "EducationLevel",
                table: "InsurancePolicies",
                newName: "CompanyCarRental");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalCondComment",
                table: "InsurancePolicies",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "InsurancePolicies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "InsurancePolicies",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "BankAccountNumber",
                table: "InsurancePolicies",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserIdentificationNumber",
                table: "InsurancePolicies",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarEndModels",
                table: "InsurancePackages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CarMaxPrice",
                table: "InsurancePackages",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CarMinPrice",
                table: "InsurancePackages",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarStartModels",
                table: "InsurancePackages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarEndModels", "CarMaxPrice", "CarMinPrice", "CarStartModels" },
                values: new object[] { null, null, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankAccountNumber",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "UserIdentificationNumber",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "CarEndModels",
                table: "InsurancePackages");

            migrationBuilder.DropColumn(
                name: "CarMaxPrice",
                table: "InsurancePackages");

            migrationBuilder.DropColumn(
                name: "CarMinPrice",
                table: "InsurancePackages");

            migrationBuilder.DropColumn(
                name: "CarStartModels",
                table: "InsurancePackages");

            migrationBuilder.RenameColumn(
                name: "VehicleUse",
                table: "InsurancePolicies",
                newName: "MaritalStatus");

            migrationBuilder.RenameColumn(
                name: "UserDocs",
                table: "InsurancePolicies",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "UserAcknowledgement",
                table: "InsurancePolicies",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "DriverCarRental",
                table: "InsurancePolicies",
                newName: "EmploymentStatus");

            migrationBuilder.RenameColumn(
                name: "CompanyCarRental",
                table: "InsurancePolicies",
                newName: "EducationLevel");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalCondComment",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicensePlateNumber",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DriveJobPart",
                table: "InsurancePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrls",
                table: "InsurancePolicies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "UserBirthDate",
                table: "InsurancePolicies",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
