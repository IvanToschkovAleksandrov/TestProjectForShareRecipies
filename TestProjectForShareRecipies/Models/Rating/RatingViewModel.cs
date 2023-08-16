using System.ComponentModel.DataAnnotations;
using TestProjectForShareRecipies.Data.Entities;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Models.Rating
{
    public class RatingViewModel
    {
        [Range(1, 5, ErrorMessage = "The rating must be between 1 and 5!")]
        public int Value { get; set; }

        [StringLength(RatingCommentMaxLength)]
        public string? Comment { get; set; }

        public DateTime Timestamp { get; set; }

        public int RecipeId { get; set; }

        public string? RecipeName { get; set; }

        public string? Author { get; set; }

        public string UserId { get; set; } = null!;
    }
}
