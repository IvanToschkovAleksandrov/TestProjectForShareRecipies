using TestProjectForShareRecipies.Models.Rating;
using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Rating
{
    public interface IRatingService
    {
        Task<RecipeDetailsModel> FindRecipeByIdAsync(int id);

        Task CreateNewRatingAsyng(RatingViewModel model);

        Task<bool> IsRated(int recipeId, string userId);
    }
}
