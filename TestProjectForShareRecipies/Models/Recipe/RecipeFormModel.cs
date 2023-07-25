using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class RecipeFormModel
    {
        [Required]
        [StringLength(RecipieNameMaxLength, MinimumLength = RecipieNameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Picture { get; set; } = null!;

        public string? Description { get; set; }

        //[Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<AllCategoriesModel> Categories { get; set; } = new List<AllCategoriesModel>();

        public IEnumerable<IngredientsFormModel> Ingredients { get; set; } = new List<IngredientsFormModel>();

        public IEnumerable<MeassureUnitsModel> MeassureUnits { get; set; } = new List<MeassureUnitsModel>();
    }
}
