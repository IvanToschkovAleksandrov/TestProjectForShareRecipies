using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text.RegularExpressions;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Data.Entities;
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
            var ingredients = new List<Ingredient>();
            string[] modelIngredients = JsonConvert.DeserializeObject<string[]>(model.Ingredients);

            foreach (string ingredientAsString in modelIngredients)
            {
                string result = ingredientAsString.Substring(0, ingredientAsString.Length - 6);
                var arrResult = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Stack<string> newStack = new Stack<string>();

                foreach(var item in arrResult)
                {
                    newStack.Push(item);
                }

                var meassureUnit = await context.MeassureUnits.FirstAsync(mu => mu.Name == newStack.Pop());
                var quantity = decimal.Parse(newStack.Pop());
                var name = string.Join(" ", newStack);

                var ingredient = new Ingredient()
                {
                    Name = name,
                    Quantity = quantity,
                    MeassureUnitId = meassureUnit.Id
                };

                ingredients.Add(ingredient);
            }
            
            var recipe = new Data.Entities.Recipe()
            {
                Name = model.Name,
                Picture = model.Picture,
                Desctiption = model.Description,
                CategoryId = model.CategoryId,
                AuthorId = model.AuthorId,
                Ingredients = ingredients
            };

            await context.Recipes.AddAsync(recipe);
            await context.SaveChangesAsync();
        }
    }
}
