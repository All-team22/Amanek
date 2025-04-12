using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedSomeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "InsuranceCompanies",
                columns: new[] { "Id", "Address", "ContactEmail", "Location", "Logo", "Name", "Phone", "RegistrationNumber", "Website" },
                values: new object[,]
                {
                    { 1, "Cairo, Egypt", "info@misrinsurance.com", "Cairo", null, "Misr Insurance", "+20 2 2399 9400", "10001", "https://www.misrins.com.eg" },
                    { 2, "Alexandria, Egypt", "support@sci-egypt.com", "Alexandria", null, "Suez Canal Insurance", "+20 3 4849 520", "10002", "https://www.sci-egypt.com" },
                    { 3, "Giza, Egypt", "contact@gig-egypt.com", "Giza", null, "GIG Egypt", "+20 2 3749 1181", "10003", "https://www.gig-egypt.com" },
                    { 4, "New Cairo, Egypt", "info@allianz.com.eg", "New Cairo", null, "Allianz Egypt", "+20 2 2260 7000", "10004", "https://www.allianz.com.eg" },
                    { 5, "Nasr City, Egypt", "service@royalinsurance.com.eg", "Nasr City", null, "Royal Insurance", "+20 2 2271 8444", "10005", "https://www.royalinsurance.com.eg" }
                });

            migrationBuilder.InsertData(
      table: "InsurancePackages",
      columns: new[] { "Id", "CompanyId", "CreatedBy", "MaintenanceSchedule", "PackageName", "PaymentFrequency", "PolicyPrice", "CarStartModels", "CarEndModels", "CarMinPrice", "CarMaxPrice" },
      values: new object[,]
      {
        { 1, 1, "Company", 2, "Basic Plan", 0, 1000.0, 2010, 2020, 10000.0, 25000.0 },
        { 2, 1, "Company", 1, "Premium Plan", 1, 2500.0, 2015, 2025, 25000.0, 50000.0 },
        { 3, 1, "Company", 0, "Pro Plan", 3, 4000.0, 2018, 2028, 40000.0, 80000.0 },
        { 4, 2, "Company", 1, "Silver Package", 0, 1200.0, 2012, 2022, 12000.0, 30000.0 },
        { 5, 2, "Company", 2, "Gold Package", 1, 2800.0, 2016, 2026, 25000.0, 60000.0 },
        { 6, 2, "Company", 0, "Platinum Package", 3, 5000.0, 2017, 2027, 50000.0, 100000.0 },
        { 7, 3, "Company", 1, "Starter Plan", 0, 800.0, 2008, 2018, 5000.0, 15000.0 },
        { 8, 3, "Company", 2, "Family Plan", 1, 3000.0, 2014, 2024, 20000.0, 45000.0 },
        { 9, 3, "Company", 0, "Elite Plan", 3, 5500.0, 2016, 2026, 40000.0, 80000.0 },
        { 10, 4, "Company", 1, "Standard Cover", 0, 1500.0, 2012, 2022, 15000.0, 35000.0 },
        { 11, 4, "Company", 2, "Advanced Cover", 1, 3200.0, 2015, 2025, 30000.0, 60000.0 },
        { 12, 4, "Company", 0, "Executive Cover", 3, 6000.0, 2018, 2028, 50000.0, 100000.0 },
        { 13, 5, "Company", 1, "Basic Shield", 0, 900.0, 2009, 2019, 8000.0, 22000.0 },
        { 14, 5, "Company", 2, "Comprehensive Shield", 1, 3500.0, 2017, 2027, 25000.0, 55000.0 },
        { 15, 5, "Company", 0, "Ultimate Shield", 3, 7000.0, 2019, 2029, 60000.0, 120000.0 }
      });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InsuranceCompanies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
