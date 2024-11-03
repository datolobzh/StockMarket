using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockMarket.Migrations
{
    /// <inheritdoc />
    public partial class seeduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6fa7d907-2d24-4703-9373-65e386817e3c", null, "Admin", "ADMIN" },
                    { "be9940e4-3b90-4fc6-86b3-450ea739c68b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fa7d907-2d24-4703-9373-65e386817e3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be9940e4-3b90-4fc6-86b3-450ea739c68b");
        }
    }
}
