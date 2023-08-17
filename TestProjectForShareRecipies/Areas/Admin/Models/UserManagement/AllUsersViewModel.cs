namespace TestProjectForShareRecipies.Areas.Admin.Models.UserManagement
{
    public class AllUsersViewModel
    {
        public string Id { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!; 
        public int RecipesCount { get; set; }
        public int RatingsCount { get; set; }
    }
}
