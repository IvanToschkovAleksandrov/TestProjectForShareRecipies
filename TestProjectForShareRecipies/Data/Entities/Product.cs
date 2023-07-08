using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; init; }

        [Required]
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(8,3)")]
        [Range(0, 99999.999, ErrorMessage = "The quantity must be a value with range 0 to 99999.999!")]
        public double Quantity { get; set; }

        [ForeignKey(nameof(MeassureUnit))]
        public int MeassureUnitId { get; set; }

        [Required]
        public MeassureUnit MeassureUnit { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Required]
        public Category Category { get; set; } = null!;
    }
}
