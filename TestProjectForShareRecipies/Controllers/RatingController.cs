using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Infrastructure;
using TestProjectForShareRecipies.Models.Rating;
using TestProjectForShareRecipies.Services.Rating;

namespace TestProjectForShareRecipies.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingService ratingService;

        public RatingController(IRatingService ratingService)
        {
            this.ratingService = ratingService;
        }

        public IActionResult All()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add(int id)
         {
            if (await ratingService.IsRated(id, User.Id()))
            {
                return Unauthorized();
            }

            var recipe = await ratingService.FindRecipeByIdAsync(id);
            var rating = new RatingViewModel()
            {
                RecipeId = id,
                UserId = User.Id(),
                RecipeName = recipe.Name,
                Author = recipe.Author
            };

            return View(rating);
        }

        [HttpPost]
        public async Task<IActionResult> Add(RatingViewModel model)
        {
            if (await ratingService.IsRated(model.RecipeId, User.Id()))
            {
                return Unauthorized();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await ratingService.CreateNewRatingAsyng(model);

            return RedirectToAction("AllRecipes", "Recipe");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
