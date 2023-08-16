using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
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

        public string? Description { get; set; }

        public double AverageRating 
        {
            get 
            {
                if (Ratings != null && Ratings.Count > 0)
                {
                    return Ratings.Average(rating => rating.Value);
                }

                return 0;
            }
        }

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

        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
