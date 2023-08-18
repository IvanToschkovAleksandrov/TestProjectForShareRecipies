using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TestProjectForShareRecipies.Areas.Admin.Models.UserManagement;
using TestProjectForShareRecipies.Areas.Admin.Services.UserManagement;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService userManagementService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserManagementController(
            IUserManagementService userManagementService,
            UserManager<ApplicationUser> userManager)
        {
            this.userManagementService = userManagementService;
            this.userManager = userManager;
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

        [HttpGet]
        public async Task<IActionResult> AddAdminRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (!await userManager.IsInRoleAsync(user, "Admin"))
            {
                await userManager.AddToRoleAsync(user, "Admin");

                if(await userManager.IsInRoleAsync(user, "User"))
                {
                    await userManager.RemoveFromRoleAsync(user, "User");
                }
            }

            return RedirectToAction(nameof(UserDetails), new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> RemoveAdminRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (await userManager.IsInRoleAsync(user, "Admin"))
            {
                await userManager.RemoveFromRoleAsync(user, "Admin");
            }

            if (!await userManager.IsInRoleAsync(user, "User"))
            {
                await userManager.AddToRoleAsync(user, "User");
            }

            return RedirectToAction(nameof(UserDetails), new { id = id});
        }
    }
}
