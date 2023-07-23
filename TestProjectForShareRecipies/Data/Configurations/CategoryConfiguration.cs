using Microsoft.EntityFrameworkCore;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Category> builder)
        {
            builder.HasData(SeedCategories());
        }

        private List<Category> SeedCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "Desserts",
                    Picture = "https://unsplash.com/photos/idTwDKt2j2o"
                },

                new Category()
                {
                    Id = 2,
                    Name = "Dinners",
                    Picture = "https://unsplash.com/photos/awj7sRviVXo"
                },

                new Category()
                {
                    Id = 3,
                    Name = "Vegeterian",
                    Picture = "https://images.unsplash.com/photo-1606307305578-9f4121dde6d9?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTR8fHZlZ2V0ZXJpYW4lMjBmb29kfGVufDB8fDB8fHww&auto=format&fit=crop&w=500&q=60"
                },

                new Category()
                {
                    Id = 4,
                    Name = "Salads",
                    Picture = "https://images.unsplash.com/photo-1600335895229-6e75511892c8?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8Nnx8c2FsYWR8ZW58MHx8MHx8fDA%3D&auto=format&fit=crop&w=500&q=60"
                },

                new Category()
                {
                    Id = 5,
                    Name = "Soups",
                    Picture = "https://images.unsplash.com/photo-1594756202469-9ff9799b2e4e?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8M3x8c291cHxlbnwwfHwwfHx8MA%3D%3D&auto=format&fit=crop&w=500&q=60"
                }
            };
        }
    }
}
