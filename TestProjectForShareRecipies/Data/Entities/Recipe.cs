using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(RecipieNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Picture { get; set; } = null!;

        public string? Desctiption { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;

        [Required]
        public ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; } = null!;
        [Required]
        public ApplicationUser Author { get; set; } = null!;
    }
}
