using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (!(await recipeService.ExistRecipeAsync(id)))
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
        public IActionResult EditRecipe()
        {
            return View();
        }

        public IActionResult DeleteRecipe()
        {
            return View();
        }


    }
}
