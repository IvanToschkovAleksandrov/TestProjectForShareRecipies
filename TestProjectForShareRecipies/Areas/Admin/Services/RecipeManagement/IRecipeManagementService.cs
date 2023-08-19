namespace TestProjectForShareRecipies.Areas.Admin.Services.RecipeManagement
{
    public interface IRecipeManagementService
    {
        Task<string> DeleteRecipeAsync(int recipeId);
        Task<string> GetUserIdByRecipeId(int recipeId);
    }
}
