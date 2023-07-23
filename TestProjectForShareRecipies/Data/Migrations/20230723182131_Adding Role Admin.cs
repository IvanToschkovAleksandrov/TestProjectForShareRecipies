using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class AddingRoleAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "713015df-3d24-4eaa-bdab-0b7b4f4cc344", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1e89f0-764e-4335-be9d-aa9f40d4e45f", "AQAAAAEAACcQAAAAEK0sTX8yTTv2gDhsIwrtCd27gXMnB02Bgf8ARYAQNG+gcpYENnjQnfkjRPvOKXwndw==", "5139e89f-499c-4999-9ba9-23835bf681d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "202919f7-4701-46ac-b79c-924d6f6a112a", "AQAAAAEAACcQAAAAEDQ7XDqb6tHpMF2lTeeZ6WWioRhwJ8GphRP6eNz1VFGaUZE2B03+oqnvnTeWgwoaaA==", "ad1fb1bb-4f20-44c3-b3b3-b794876d1077" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "162bb2c2-b78b-4a43-9318-271e17ebd9b4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "162bb2c2-b78b-4a43-9318-271e17ebd9b4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd679ce4-5d23-473a-91be-2f3461417c7d", "AQAAAAEAACcQAAAAEMh+ks6xbs0UiZIu5aYuReOfLRb25gmECDq1hkUL+ZI0CoXHLMecm14kfzpJQYo5/Q==", "5a9c98a3-df9e-4400-9b8c-dad08f0778c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "953b3760-8405-4e37-8e2e-786fcd4ef7f1", "AQAAAAEAACcQAAAAEGaiTJzmcvJValaOPnqDmOSCB9lbEVPXl0tXflzzyerCTb5Zs/NR/zZwR/SvV1oa+Q==", "0e755f2c-5e8b-4c76-a972-89216636599d" });
        }
    }
}
