using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameMaxLength)]
        public string Name { get; set; } = null!;

    }
}
