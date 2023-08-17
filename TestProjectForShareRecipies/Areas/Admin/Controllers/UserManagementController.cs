using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Areas.Admin.Models.UserManagement;
using TestProjectForShareRecipies.Areas.Admin.Services.UserManagement;

namespace TestProjectForShareRecipies.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService userManagementService;

        public UserManagementController(IUserManagementService userManagementService)
        {
            this.userManagementService = userManagementService;
        }

        [HttpGet]
        public async Task<IActionResult> AllUsers()
        {
            var model = await userManagementService.AllUsersAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UserDetails(string id)
        {
            var model = await userManagementService.GetUserDetailsAsync(id);

            return View(model);
        }
    }
}
