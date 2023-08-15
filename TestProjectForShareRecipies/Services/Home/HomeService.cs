using Microsoft.EntityFrameworkCore;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Models.Home;

namespace TestProjectForShareRecipies.Services.Home
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext context;

        public HomeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<RecipeIndexModel>> LastThreeRecipesAsync()
        {
            return await context.Recipes
                .OrderByDescending(r => r.Id)
                .Select(r => new RecipeIndexModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Picture = r.Picture,
                    CategoryId = r.CategoryId
                })
                .Take(3)
                .ToListAsync();
        }
    }
}
