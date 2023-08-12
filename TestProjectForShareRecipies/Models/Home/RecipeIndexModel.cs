using System.ComponentModel.DataAnnotations;

namespace TestProjectForShareRecipies.Models.Home
{
    public class RecipeIndexModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public int CategoryId { get; set; }
    }
}
