using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(SeedUserRoles());
        }

        private List<IdentityUserRole<string>> SeedUserRoles()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                {
                    UserId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                    RoleId = "1"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                    RoleId = "2"
                }
            };
        }
    }
}
