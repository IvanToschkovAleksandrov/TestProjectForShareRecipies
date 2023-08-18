using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TestProjectForShareRecipies.Areas.Admin.Models.UserManagement;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Areas.Admin.Services.UserManagement
{
    public class UserManagementService : IUserManagementService
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public UserManagementService(
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IEnumerable<AllUsersViewModel>> AllUsersAsync()
        {
            return await context.Users
                .Include(u => u.Ratings)
                .Include(u => u.Recipes)
                .Select(u => new AllUsersViewModel()
                {
                    Id = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    RatingsCount = u.Ratings.Count(),
                    RecipesCount = u.Recipes.Count()
                })
                .ToListAsync();
        }

        public async Task<UserDetailsModel> GetUserDetailsAsync(string userId)
        {
            var user = await context.Users
                .Include(u => u.Ratings)
                .Include(u => u.Recipes)
                .FirstAsync(u => u.Id == userId);

            if (user == null)
            {
                throw new Exception("There is no such User in the Database!");
            }

            var modelUser = new UserDetailsModel()
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Ratings = user.Ratings.Select(r => new RatingDetailsModel()
                {
                    Value = r.Value,
                    Comment = r.Comment ?? String.Empty,
                    Timestamp = r.Timestamp
                })
                .ToList(),
                Recipes = user.Recipes.Select(r => new RecipeDetailsModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description ?? String.Empty,
                    Picture = r.Picture,
                    Rating = r.AverageRating
                }),
                Roles = await userManager.GetRolesAsync(user)
            };

            return modelUser;
        }

    }
}
