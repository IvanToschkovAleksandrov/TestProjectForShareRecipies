using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(SeedUsers());
        }
        
        private List<ApplicationUser> SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var users = new List<ApplicationUser>();

            var user = new ApplicationUser()
            {
                Id = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                FirstName = "Ivan",
                LastName = "Aleksandrov",
                Email = "ivan.aleksandrov@gmail.com",
            };

            user.PasswordHash = hasher.HashPassword(user, "ivan13");
            users.Add(user);

            user = new ApplicationUser()
            {
                Id = "d5ab93a3-c7cf-4328-80f4-705121dfe864",
                FirstName = "Petar",
                LastName = "Petrov",
                Email = "petar.petrov@gmail.com"
            };

            user.PasswordHash = hasher.HashPassword(user, "petar13");
            users.Add(user);

            return users;
        }
    }
}
