using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class MeassureUnit
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MeassureUnitNameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
