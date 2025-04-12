using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addrelwithpackageonpolicytogether : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InsurancePackageId",
                table: "InsurancePolicies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_InsurancePackageId",
                table: "InsurancePolicies",
                column: "InsurancePackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsurancePackages_InsurancePackageId",
                table: "InsurancePolicies",
                column: "InsurancePackageId",
                principalTable: "InsurancePackages",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsurancePackages_InsurancePackageId",
                table: "InsurancePolicies");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_InsurancePackageId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "InsurancePackageId",
                table: "InsurancePolicies");
        }
    }
}
