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

        public IActionResult Error(int statusCode)
        {
            ViewData["StatusCode"] = statusCode;

            if (statusCode == 400 || statusCode == 401)
            {
                return View($"Error{statusCode}");
            }
            return View();
        }
    }
}