using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Recipe
{
    public interface IRecipeService
    {
        Task<IEnumerable<AllCategoriesModel>> AllCategoriesAsync();

        Task<IEnumerable<MeassureUnitsModel>> AllMeassureUnitsAsync();

        Task CreateAsync(RecipeFormModel model);
    }
}
