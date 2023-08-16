using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 5, ErrorMessage = "The rating must be between 1 and 5!")]
        public int Value { get; set; }

        [StringLength(RatingCommentMaxLength)]
        public string? Comment { get; set; }

        public DateTime Timestamp { get; set; }

        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
    }
}
