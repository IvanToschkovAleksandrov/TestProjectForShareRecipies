using Microsoft.EntityFrameworkCore;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Recipe
{
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext context;

        public RecipeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AllCategoriesModel>> AllCategoriesAsync()
        {
            return await context
                .Categories
                .Select(c => new AllCategoriesModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<MeassureUnitsModel>> AllMeassureUnitsAsync()
        {
            return await context
                .MeassureUnits
                .Select(mu => new MeassureUnitsModel()
                {
                    Id = mu.Id,
                    Name = mu.Name
                })
                .ToListAsync();
        }

        public async Task CreateAsync(RecipeFormModel model)
        {
            var recipe = new Data.Entities.Recipe()
            {
                Name = model.Name,
                Picture = model.Picture,
                Desctiption = model.Description,
                CategoryId = model.CategoryId,
            };

            await context.Recipes.AddAsync(recipe);
            await context.SaveChangesAsync();
        }
    }
}
