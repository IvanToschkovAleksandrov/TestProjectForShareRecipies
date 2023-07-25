using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Data.Entities;
using TestProjectForShareRecipies.Models.Recipe;
using TestProjectForShareRecipies.Services.Recipe;

namespace TestProjectForShareRecipies.Controllers
{
    //[Authorize]
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult AllRecipes()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddRecipe()
        {
            var model = new RecipeFormModel();

            //We have to load all Categories from the DataBase and put in the RecipeFormModel
            model.Categories = await recipeService.AllCategoriesAsync();
            model.MeassureUnits = await recipeService.AllMeassureUnitsAsync();

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
