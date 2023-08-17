namespace TestProjectForShareRecipies.Areas.Admin.Models.UserManagement
{
    public class UserDetailsModel
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public IEnumerable<string> Roles { get; set; } = new List<string>();
        public IEnumerable<RecipeDetailsModel> Recipes { get; set; } = new List<RecipeDetailsModel>();
        public IEnumerable<RatingDetailsModel> Ratings { get; set; } = new List<RatingDetailsModel>();
    }
}
