using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Areas.Admin.Services.RecipeManagement;

namespace TestProjectForShareRecipies.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RecipeManagementController : Controller
    {
        private readonly IRecipeManagementService recipeManagementService;

        public RecipeManagementController(IRecipeManagementService recipeManagementService)
        {
            this.recipeManagementService = recipeManagementService;
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRecipe(int id)
        {
            var userId = await recipeManagementService.DeleteRecipeAsync(id);

            return RedirectToAction("UserDetails", "UserManagement", new {id = userId});
        }
    }
}
