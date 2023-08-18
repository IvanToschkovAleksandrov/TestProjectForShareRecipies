namespace TestProjectForShareRecipies.Areas.Admin.Models.UserManagement
{
    public class RecipeDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Rating { get; set; }
    }
}
