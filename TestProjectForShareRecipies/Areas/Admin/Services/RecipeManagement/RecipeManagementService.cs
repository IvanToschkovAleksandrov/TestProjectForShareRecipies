using Microsoft.EntityFrameworkCore;
using TestProjectForShareRecipies.Data;

namespace TestProjectForShareRecipies.Areas.Admin.Services.RecipeManagement
{
    public class RecipeManagementService : IRecipeManagementService
    {
        private readonly ApplicationDbContext context;

        public RecipeManagementService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<string> DeleteRecipeAsync(int recipeId)
        {
            var recipe = await context.Recipes.Include(r => r.Ratings).FirstOrDefaultAsync(r => r.Id == recipeId);

            if (recipe == null)
            {
                throw new NullReferenceException("The recipe you wan't to Delete is not in the Database already!");
            }

            var authorId = recipe.AuthorId;
            context.Ratings.RemoveRange(recipe.Ratings);
            context.Recipes.Remove(recipe);
            await context.SaveChangesAsync();

            return authorId;
        }

        public async Task<string> GetUserIdByRecipeId(int recipeId)
        {
            var recipe = await context.Recipes.FirstOrDefaultAsync(r => r.Id == recipeId);

            if (recipe == null)
            {
                throw new NullReferenceException("Sorry but the author is unknown beacause of this recipe is no longer in a database.");
            }

            return recipe.AuthorId;
        }
    }
}
