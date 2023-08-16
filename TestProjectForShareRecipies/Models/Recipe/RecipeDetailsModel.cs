using TestProjectForShareRecipies.Models.Rating;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class RecipeDetailsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string Picture { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Category { get; set; } = null!;
        public double AverrageRating { get; set; }
        public IEnumerable<IngredientDetailsModel> Ingredients { get; set; } = new List<IngredientDetailsModel>();
        public IEnumerable<RatingsDetailsModel> Ratings { get; set; } = new List<RatingsDetailsModel>();
    }
}
