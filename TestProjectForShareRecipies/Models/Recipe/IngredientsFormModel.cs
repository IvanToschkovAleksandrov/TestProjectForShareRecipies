using System.ComponentModel.DataAnnotations;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class IngredientsFormModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        [Range(0, 99999.999, ErrorMessage = "The quantity must be a value with range 0 to 99999.999!")]
        public decimal Quantity { get; set; }

        public int MeassureUnitId { get; set; }

    }
}
