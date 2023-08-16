using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Data.Entities;
using TestProjectForShareRecipies.Models.Rating;
using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Rating
{
    public class RatingService : IRatingService
    {
        private readonly ApplicationDbContext context;

        public RatingService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task CreateNewRatingAsyng(RatingViewModel model)
        {
            var rating = new Data.Entities.Rating()
            {
                Value = model.Value,
                Comment = model.Comment,
                RecipeId = model.RecipeId,
                Timestamp = model.Timestamp,
                UserId = model.UserId,
            };

            await context.Ratings.AddAsync(rating);
            await context.SaveChangesAsync();
        }

        public async Task<RecipeDetailsModel> FindRecipeByIdAsync(int id)
        {
            return await context.Recipes.Where(r => r.Id == id)
                .Select(r => new RecipeDetailsModel()
                {
                    Author = String.Join(" ", new[] { r.Author.FirstName, r.Author.LastName }),
                    Description = r.Description,
                    Id = r.Id,
                    Name = r.Name,
                    Picture = r.Picture
                })
                .FirstAsync();
        }

        public async Task<bool> IsRated(int recipeId, string userId)
        {
            var recipe = await context.Recipes
                .Include(r => r.Ratings)
                .FirstAsync(r => r.Id == recipeId);
                

            return recipe != null && recipe.Ratings.Any(u => u.UserId == userId);
        }
    }
}
