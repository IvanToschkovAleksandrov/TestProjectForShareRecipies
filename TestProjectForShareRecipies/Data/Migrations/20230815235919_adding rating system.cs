using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class addingratingsystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_RecipeId",
                table: "Ratings",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ratings");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a72db372-7409-4b0a-82b5-bb09ae698bbe", "AQAAAAEAACcQAAAAEKTUwRpW9qM0fRC/CWdQ8HdC4+5zY3t6QvcDDESWqtv90CXON/4AEdgX1Bs7tj3k+Q==", "eeab65ad-27df-452e-956b-622a2d28e9f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4a0570a-361a-4470-883c-051a720a08e2", "AQAAAAEAACcQAAAAECIxaHBcRZKTt/6o2oer07waFgN64sI+BEOHu+ztsPfyYO7MwNqDmMg6aQAI3DyVMQ==", "22325629-c9db-492e-99af-2ca4644fca9c" });
        }
    }
}
