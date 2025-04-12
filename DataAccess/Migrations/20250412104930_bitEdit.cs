using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class bitEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CarStartModels",
                table: "InsurancePackages",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarEndModels",
                table: "InsurancePackages",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CarStartModels",
                table: "InsurancePackages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CarEndModels",
                table: "InsurancePackages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "InsurancePackages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CarEndModels", "CarStartModels" },
                values: new object[] { null, null });
        }
    }
}
