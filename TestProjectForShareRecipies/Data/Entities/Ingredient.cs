using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class Ingredient
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(8,3)")]
        [Range(0, 99999.999, ErrorMessage = "The quantity must be a value with range 0 to 99999.999!")]
        public decimal Quantity { get; set; }

        [ForeignKey(nameof(MeassureUnit))]
        public int MeassureUnitId { get; set; }
        public MeassureUnit MeassureUnit { get; set; } = null!;

        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;
    }
}
