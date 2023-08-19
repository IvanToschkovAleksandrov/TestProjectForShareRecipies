using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using TestProjectForShareRecipies.Areas.Admin.Services.RecipeManagement;
using TestProjectForShareRecipies.Areas.Admin.Services.UserManagement;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Data.Entities;
using TestProjectForShareRecipies.Services.Home;
using TestProjectForShareRecipies.Services.Rating;
using TestProjectForShareRecipies.Services.Recipe;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IHomeService, HomeService>();
builder.Services.AddScoped<IRatingService, RatingService>();
builder.Services.AddScoped<IUserManagementService, UserManagementService>();
builder.Services.AddScoped<IRecipeManagementService, RecipeManagementService>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.MapRazorPages();

app.Run();