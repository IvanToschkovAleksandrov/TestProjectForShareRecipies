using System.ComponentModel.DataAnnotations;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class IngredientDetailsModel
    {
        public string Name { get; set; } = null!;

        public decimal Quantity { get; set; }

        public string MeassureUnit { get; set; }

    }
}
