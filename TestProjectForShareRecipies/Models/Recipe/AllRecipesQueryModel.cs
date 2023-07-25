using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class AllRecipesQueryModel
    {
        public string Category { get; set; } = null!;
        public List<string> Categories { get; set; } = new List<string>();
    }
}
