using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class changenameofthecolumnDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Desctiption",
                table: "Recipes",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "3a2bfc8d-a711-414a-8ea0-12c99fc93de4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3cfb2ba-a685-4c0a-ac67-642b5c7297d7", "AQAAAAEAACcQAAAAEP8Gn6WPi0b/fVcIrUvPF0dJFt1pdzaKsPocZRB7ecGrmFGA43JTedx1vqix9sy6Rw==", "113410d9-75a1-452b-9831-da5f2be97473" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d1c27a3-45c3-4aad-9eae-4d22e7f3cfc5", "AQAAAAEAACcQAAAAEFhlN7r863ZcQxiC/Y+wIjpHVvfk6PZCHoALPeVYIATKLHy1JvpSj3gg7/DtDngh2Q==", "a566ec83-67da-4f60-a847-7eff1dfe162f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Recipes",
                newName: "Desctiption");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d4aaa5c0-12d3-4be2-ba38-b710d9d4f96e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975b89c8-b0ec-4736-98ee-1b5775af2d7d", "AQAAAAEAACcQAAAAEMK6bDaRJCTHkAoWSWgQtqifSYU7UQBcAcD+HslU2UiskgsaC+ui7kBowSlNHpdnCw==", "4196310d-fe8e-478e-9a40-8adafe20e778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2000826-6464-40eb-9878-ad9d434c6cdb", "AQAAAAEAACcQAAAAEAPxmimr6iCGKSQGnr8zTSGpZqcGlVTWatSR48Nhesgb7+1EWmvg6HGfO9PnCK8Jtg==", "cd2d392f-5ec9-4567-8db2-24bbbb54e1df" });
        }
    }
}
