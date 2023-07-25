using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class MeassureUnitsModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(MeassureUnitNameMaxLength, MinimumLength = MeassureUnitNameMinLength)]
        public string Name { get; set; } = null!;
    }
}
