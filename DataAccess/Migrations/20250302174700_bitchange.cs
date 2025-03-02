using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bitchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePackages_InsuranceCompanies_CompanyId",
                table: "InsurancePackages");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "InsurancePackages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePackages_InsuranceCompanies_CompanyId",
                table: "InsurancePackages",
                column: "CompanyId",
                principalTable: "InsuranceCompanies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsurancePackages_InsuranceCompanies_CompanyId",
                table: "InsurancePackages");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "InsurancePackages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsurancePackages_InsuranceCompanies_CompanyId",
                table: "InsurancePackages",
                column: "CompanyId",
                principalTable: "InsuranceCompanies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
