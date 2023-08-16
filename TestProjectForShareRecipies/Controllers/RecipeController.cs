using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using TestProjectForShareRecipies.Infrastructure;
using TestProjectForShareRecipies.Models.Recipe;
using TestProjectForShareRecipies.Services.Recipe;

namespace TestProjectForShareRecipies.Controllers
{
    [Authorize]
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService) 
        {
            this.recipeService = recipeService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> AllRecipes([FromQuery]AllRecipesQueryModel query)
        {
            var model = await recipeService.AllRecipesAsync(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllRecipesQueryModel.RecipesPerPage);

            query.TotalRecipesCount = model.TotalRecipesCount;
            query.Recipes = model.Recipes;

            query.Categories = await recipeService.AllCategoriesNamesAsync(); 

            return View(query);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!await recipeService.ExistRecipeAsync(id))
            {
                return BadRequest();
            }

            var model = await recipeService.RecipeDetailsByIdAsync(id);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddRecipe()
        {
            var model = new RecipeFormModel();

            model.Categories = await recipeService.AllCategoriesAsync();
            model.MeassureUnits = await recipeService.AllMeassureUnitsAsync();
            model.AuthorId = User.Id();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(RecipeFormModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await recipeService.CreateAsync(model);
            
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if(!await recipeService.ExistRecipeAsync(id))
            {
                return BadRequest();
            }

            if (!await recipeService.IsTheOwnerOfTheRecipe(id, User.Id()))
            {
                return Unauthorized();
            }

            var recipe = await recipeService.RecipeDetailsByIdAsync(id);
            var builder = new StringBuilder();
            List<string> ingredientsList = new List<string>();

            foreach (var ingredient in recipe.Ingredients)
            {
                builder.Append(ingredient.Name);
                builder.Append(" ");
                builder.Append(ingredient.Quantity);
                builder.Append(" ");
                builder.Append(ingredient.MeassureUnit);
                ingredientsList.Add(builder.ToString());
                builder.Clear();
            }
            var ingredients = JsonConvert.SerializeObject(ingredientsList);

            var recipeModel = new RecipeFormModel()
            {
                Name = recipe.Name,
                Description = recipe.Description,
                Picture = recipe.Picture,
                AuthorId = User.Id(),
                Ingredients = ingredients,
                Categories = await recipeService.AllCategoriesAsync(),
                MeassureUnits = await recipeService.AllMeassureUnitsAsync(),
                CategoryId = (await recipeService.GetCategoryByNameAsync(recipe.Category)).Id
            };

            return View(recipeModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(RecipeFormModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!await recipeService.ExistRecipeAsync(id))
            {
                return BadRequest();
            }

            if (!await recipeService.IsTheOwnerOfTheRecipe(id, User.Id()))
            {
                return Unauthorized();
            }

            await recipeService.EditRecipeAsync(model, id);

            return RedirectToAction(nameof(Details), new { id = id });

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (!await recipeService.ExistRecipeAsync(id))
            {
                return BadRequest();
            }

            if (!await recipeService.IsTheOwnerOfTheRecipe(id, User.Id()))
            {
                return Unauthorized();
            }

            var model = await recipeService.RecipeDetailsByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(RecipeDetailsModel model, int id)
        {
            if (!await recipeService.ExistRecipeAsync(id))
            {
                return BadRequest();
            }

            if (!await recipeService.IsTheOwnerOfTheRecipe(id, User.Id()))
            {
                return Unauthorized();
            }

            await recipeService.DeleteAsync(id);

            return RedirectToAction(nameof(AllRecipes));
        }
    }
}
