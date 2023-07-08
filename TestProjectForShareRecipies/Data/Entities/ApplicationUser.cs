using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TestProjectForShareRecipies.Data.DataConstants;

namespace TestProjectForShareRecipies.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(UserNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(UserNameMaxLength)]
        public string LastName { get; set; } = null!;
    }
}
