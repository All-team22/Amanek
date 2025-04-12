using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addrelwithpackageonpolicy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "packageId",
                table: "InsurancePolicies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePolicies_packageId",
                table: "InsurancePolicies",
                column: "packageId");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePolicies_InsurancePackages_packageId",
                table: "InsurancePolicies",
                column: "packageId",
                principalTable: "InsurancePackages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePolicies_InsurancePackages_packageId",
                table: "InsurancePolicies");

            migrationBuilder.DropIndex(
                name: "IX_InsurancePolicies_packageId",
                table: "InsurancePolicies");

            migrationBuilder.DropColumn(
                name: "packageId",
                table: "InsurancePolicies");
        }
    }
}
