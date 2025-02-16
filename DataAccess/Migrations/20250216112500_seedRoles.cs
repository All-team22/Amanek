using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Roles",
               columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
               values: new object[,]
               {
            { Guid.NewGuid().ToString(), "Admin", "ADMIN", Guid.NewGuid().ToString() },
            { Guid.NewGuid().ToString(), "Customer", "Customer", Guid.NewGuid().ToString() },
            { Guid.NewGuid().ToString(), "Company", "Company", Guid.NewGuid().ToString() }
               }
           );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
              table: "Roles",
              keyColumn: "Name",
              keyValues: new object[] { "Admin", "Customer", "Company" }
          );
        }
    }
}
