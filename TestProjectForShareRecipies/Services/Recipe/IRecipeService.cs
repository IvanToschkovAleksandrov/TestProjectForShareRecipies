using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Recipe
{
    public interface IRecipeService
    {
        Task<IEnumerable<AllCategoriesModel>> AllCategoriesAsync();

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<MeassureUnitsModel>> AllMeassureUnitsAsync();

        Task CreateAsync(RecipeFormModel model);

        Task<RecipeQueryServiceModel> AllRecipesAsync(
            string? Category = null,
            string? SearchTerm = null,
            RecipeSorting sorting = RecipeSorting.Newest,
            int CurrentPage = 1,
            int RecipePerPage = 1);

        Task<bool> ExistRecipeAsync(int id);

        Task<RecipeDetailsModel> RecipeDetailsByIdAsync(int id);
    }
}
