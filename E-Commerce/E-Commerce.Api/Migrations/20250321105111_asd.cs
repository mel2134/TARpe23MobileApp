using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Api.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "#E1F1E7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BgColor",
                value: "#E1F1E7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "FFFF00");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "DAD1F9");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 1,
                column: "BgColor",
                value: "7FBDC7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 2,
                column: "BgColor",
                value: "7FBDC7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 3,
                column: "BgColor",
                value: "#E1F1E7");

            migrationBuilder.UpdateData(
                table: "Offer",
                keyColumn: "Id",
                keyValue: 4,
                column: "BgColor",
                value: "FFFF00");
        }
    }
}
