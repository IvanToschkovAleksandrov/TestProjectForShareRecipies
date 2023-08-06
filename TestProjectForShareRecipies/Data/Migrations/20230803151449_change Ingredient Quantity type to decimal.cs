using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class changeIngredientQuantitytypetodecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1db6165b-58d7-40a3-9d3e-a5d4aa6bce3b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13045413-1c68-4cca-877f-687de34cb53f", "AQAAAAEAACcQAAAAEBCPwP0x0GPpWVZFNlahEgXK9OOM9J5oUZNkCK5DEzUuYTfAhlm814vbbysqE9+JHA==", "574e6a9a-4825-408f-bb0d-322ab9533c48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d8b950d-d23d-4313-bb7c-708b6f9e396e", "AQAAAAEAACcQAAAAEBpzzOhS9B1Ygmc71J2FJ8rEjeBDxVkUKdun8/v4UqJK2UBpErvrLXPTcwsOwykR2g==", "3c5bc2cb-b52d-440a-8a0f-b8ab4e849824" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "713015df-3d24-4eaa-bdab-0b7b4f4cc344");

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
        }
    }
}
