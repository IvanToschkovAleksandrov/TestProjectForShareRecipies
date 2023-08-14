using TestProjectForShareRecipies.Models.Home;

namespace TestProjectForShareRecipies.Services.Home
{
    public interface IHomeService
    {
        Task<IEnumerable<RecipeIndexModel>> LastThreeRecipesAsync();
        
    }
}
