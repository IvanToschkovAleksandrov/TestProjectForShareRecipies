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
        public IEnumerable<IngredientDetailsModel> Ingredients { get; set; } = new List<IngredientDetailsModel>();
    }
}
