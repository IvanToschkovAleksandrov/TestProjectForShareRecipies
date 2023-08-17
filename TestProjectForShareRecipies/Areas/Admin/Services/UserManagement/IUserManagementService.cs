using TestProjectForShareRecipies.Areas.Admin.Models.UserManagement;

namespace TestProjectForShareRecipies.Areas.Admin.Services.UserManagement
{
    public interface IUserManagementService
    {
        Task<IEnumerable<AllUsersViewModel>> AllUsersAsync();
        Task<UserDetailsModel> GetUserDetailsAsync(string userId);
    }
}
