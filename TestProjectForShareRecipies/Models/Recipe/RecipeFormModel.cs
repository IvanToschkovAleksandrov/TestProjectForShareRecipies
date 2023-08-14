using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class RecipeFormModel
    {
        [Required(ErrorMessage = "Трябва да пишеш нещо!")]
        [StringLength(RecipieNameMaxLength, MinimumLength = RecipieNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Picture { get; set; } = null!;

        public string? Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string AuthorId { get; set; } = null!;

        public IEnumerable<AllCategoriesModel> Categories { get; set; } = new List<AllCategoriesModel>();

        public string Ingredients { get; set; } = null!;

        public IEnumerable<MeassureUnitsModel> MeassureUnits { get; set; } = new List<MeassureUnitsModel>();
    }
}
