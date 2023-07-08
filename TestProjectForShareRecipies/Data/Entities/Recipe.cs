using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        public ICollection<Product> Products { get; set; } = new List<Product>();

        [Required]
        public IdentityUser Author { get; set; } = null!;
    }
}
