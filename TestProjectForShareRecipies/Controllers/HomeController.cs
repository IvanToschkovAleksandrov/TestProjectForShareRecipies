using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Services.Home;

namespace TestProjectForShareRecipies.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await homeService.LastThreeRecipesAsync();

            return View(model);
        }
    }
}