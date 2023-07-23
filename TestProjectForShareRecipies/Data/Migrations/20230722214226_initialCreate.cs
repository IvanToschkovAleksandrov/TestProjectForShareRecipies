using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestProjectForShareRecipies.Data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeassureUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeassureUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desctiption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recipes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(8,3)", nullable: false),
                    MeassureUnitId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients_MeassureUnits_MeassureUnitId",
                        column: x => x.MeassureUnitId,
                        principalTable: "MeassureUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "162bb2c2-b78b-4a43-9318-271e17ebd9b4", 0, "dd679ce4-5d23-473a-91be-2f3461417c7d", "ivan.aleksandrov@gmail.com", false, "Ivan", "Aleksandrov", false, null, null, null, "AQAAAAEAACcQAAAAEMh+ks6xbs0UiZIu5aYuReOfLRb25gmECDq1hkUL+ZI0CoXHLMecm14kfzpJQYo5/Q==", null, false, "5a9c98a3-df9e-4400-9b8c-dad08f0778c7", false, null },
                    { "d5ab93a3-c7cf-4328-80f4-705121dfe864", 0, "953b3760-8405-4e37-8e2e-786fcd4ef7f1", "petar.petrov@gmail.com", false, "Petar", "Petrov", false, null, null, null, "AQAAAAEAACcQAAAAEGaiTJzmcvJValaOPnqDmOSCB9lbEVPXl0tXflzzyerCTb5Zs/NR/zZwR/SvV1oa+Q==", null, false, "0e755f2c-5e8b-4c76-a972-89216636599d", false, null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, "Desserts", "https://unsplash.com/photos/idTwDKt2j2o" },
                    { 2, "Dinners", "https://unsplash.com/photos/awj7sRviVXo" },
                    { 3, "Vegeterian", "https://images.unsplash.com/photo-1606307305578-9f4121dde6d9?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHZlZ2V0ZXJpYW4lMjBmb29kfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60" },
                    { 4, "Salads", "https://images.unsplash.com/photo-1600335895229-6e75511892c8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8c2FsYWR8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60" },
                    { 5, "Soups", "https://images.unsplash.com/photo-1594756202469-9ff9799b2e4e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8c291cHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60" }
                });

            migrationBuilder.InsertData(
                table: "MeassureUnits",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "kg" },
                    { 2, "l" },
                    { 3, "grams" },
                    { 4, "ml" },
                    { 5, "count" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Desctiption", "Name", "Picture" },
                values: new object[] { 1, "162bb2c2-b78b-4a43-9318-271e17ebd9b4", 5, "This chicken vegetable soup is so easy to make by cooking everything in one pot using a few ingredients that take less than one hour, making it perfect for busy midweek dinners.", "Chicken Soup", "https://comfortablefood.com/wp-content/uploads/2022/08/Chicken-vegetable-soup-11-1440x1440.jpg" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Desctiption", "Name", "Picture" },
                values: new object[] { 2, "162bb2c2-b78b-4a43-9318-271e17ebd9b4", 5, "Lentil potato soup does not require much cooking equipment to prepare this dish, just a large pot for cooking the ingredients and a chopping board.", "Lentil Potato Soup", "https://comfortablefood.com/wp-content/uploads/2021/11/featured-lentil-potato-soup.jpg" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "MeassureUnitId", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { 1, 3, "Chicken Legs", 350m, 1 },
                    { 2, 3, "Onion", 50m, 1 },
                    { 3, 3, "Carrot", 50m, 1 },
                    { 4, 3, "Celery stalk", 50m, 1 },
                    { 5, 3, "Frozen Peas and Corn", 150m, 1 },
                    { 6, 3, "Fresh parsley", 5m, 1 },
                    { 7, 3, "Salt", 5m, 1 },
                    { 8, 3, "Lentil", 250m, 2 },
                    { 9, 3, "Potato", 250m, 2 },
                    { 10, 3, "Carrot", 50m, 2 },
                    { 11, 3, "Celery Stalk", 50m, 2 },
                    { 12, 3, "Onion", 50m, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_MeassureUnitId",
                table: "Ingredients",
                column: "MeassureUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_AuthorId",
                table: "Recipes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "MeassureUnits");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5ab93a3-c7cf-4328-80f4-705121dfe864");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "162bb2c2-b78b-4a43-9318-271e17ebd9b4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
