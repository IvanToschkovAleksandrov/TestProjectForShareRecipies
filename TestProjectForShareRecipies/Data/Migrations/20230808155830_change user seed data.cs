using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class changeuserseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "75f11362-ef42-42bb-a46d-90b01c04883a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a72db372-7409-4b0a-82b5-bb09ae698bbe", "IVAN.ALEKSANDROV@GMAIL.COM", "IVAN.ALEKSANDROV@GMAIL.COM", "AQAAAAEAACcQAAAAEKTUwRpW9qM0fRC/CWdQ8HdC4+5zY3t6QvcDDESWqtv90CXON/4AEdgX1Bs7tj3k+Q==", "eeab65ad-27df-452e-956b-622a2d28e9f5", "ivan.aleksandrov@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c4a0570a-361a-4470-883c-051a720a08e2", "PETAR.PETROV@GMAIL.COM", "PETAR.PETROV@GMAIL.COM", "AQAAAAEAACcQAAAAECIxaHBcRZKTt/6o2oer07waFgN64sI+BEOHu+ztsPfyYO7MwNqDmMg6aQAI3DyVMQ==", "22325629-c9db-492e-99af-2ca4644fca9c", "petar.petrov@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "13045413-1c68-4cca-877f-687de34cb53f", null, null, "AQAAAAEAACcQAAAAEBCPwP0x0GPpWVZFNlahEgXK9OOM9J5oUZNkCK5DEzUuYTfAhlm814vbbysqE9+JHA==", "574e6a9a-4825-408f-bb0d-322ab9533c48", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2d8b950d-d23d-4313-bb7c-708b6f9e396e", null, null, "AQAAAAEAACcQAAAAEBpzzOhS9B1Ygmc71J2FJ8rEjeBDxVkUKdun8/v4UqJK2UBpErvrLXPTcwsOwykR2g==", "3c5bc2cb-b52d-440a-8a0f-b8ab4e849824", null });
        }
    }
}
