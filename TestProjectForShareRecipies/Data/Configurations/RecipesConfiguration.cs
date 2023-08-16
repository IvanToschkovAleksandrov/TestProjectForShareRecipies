using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class RecipesConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(SeedRecipies());
        }

        private List<Recipe> SeedRecipies()
        {
            List<Recipe> recipes = new List<Recipe>();

            Recipe chickenSoup = new Recipe()
            {
                Id = 1,
                Name = "Chicken Soup",
                CategoryId = 5,
                AuthorId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                Description = "This chicken vegetable soup is so easy to make by cooking everything in one pot using a few ingredients that take less than one hour, making it perfect for busy midweek dinners.",
                Picture = "https://comfortablefood.com/wp-content/uploads/2022/08/Chicken-vegetable-soup-11-1440x1440.jpg"
            };

            recipes.Add(chickenSoup);

            Recipe lentilPotatoSoup = new Recipe()
            {
                Id = 2,
                Name = "Lentil Potato Soup",
                AuthorId = "162bb2c2-b78b-4a43-9318-271e17ebd9b4",
                CategoryId = 5,
                Description = "Lentil potato soup does not require much cooking equipment to prepare this dish, just a large pot for cooking the ingredients and a chopping board.",
                Picture = "https://comfortablefood.com/wp-content/uploads/2021/11/featured-lentil-potato-soup.jpg"
            };

            recipes.Add(lentilPotatoSoup);

            return recipes;
        }
    }
}
