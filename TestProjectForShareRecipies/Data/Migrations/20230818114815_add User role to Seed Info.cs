using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class addUserroletoSeedInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "5e8e6d85-a77f-40f4-a665-95340603ec0b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "5a881587-2701-469f-a8b6-51117933a8ed", "User", "USER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d69255b0-fb65-4ab0-9cd7-f8fc2d51d440", "AQAAAAEAACcQAAAAEOreSlDa0tFETjKzxKEghETHaMxfbILJlik7aCs0+j4uihBsEMI4sKfdbh5yuCs9pQ==", "94632f4f-aaac-4b97-8d36-263fb9caeb37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac2c33dd-571e-4705-9948-d0556d8aace6", "AQAAAAEAACcQAAAAEF0P8O1oZfQ3jqNTC6S5WBwv0UrOq++5WLFmNjOlkdTcIqzmWdy3G0Z/KwVeUtvp7A==", "843c97b9-eb4c-4c79-b9b5-d7c6b780c9e9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "d5ab93a3-c7cf-4328-80f4-705121dfe864" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "d5ab93a3-c7cf-4328-80f4-705121dfe864" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

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
    }
}
