using System.ComponentModel.DataAnnotations;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class AllRecipesQueryModel
    {
        public const int RecipesPerPage = 3;

        [Display(Name = "Search Term")]
        public string SearchTerm { get; set; } = null!;

        public RecipeSorting Sorting { get; set; }

        public string Category { get; set; } = null!;

        public int CurrentPage { get; set; } = 1;

        public int TotalRecipesCount { get; set; }

        public double AverageRating { get; set; } 

        public IEnumerable<string> Categories { get; set; } = new List<string>();

        public IEnumerable<RecipeServiceModel> Recipes { get; set; } = new List<RecipeServiceModel>();
    }
}
