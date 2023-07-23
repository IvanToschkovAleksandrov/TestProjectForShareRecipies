using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestProjectForShareRecipies.Data.Entities;

namespace TestProjectForShareRecipies.Data.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasData(SeedIngredients());
        }

        private List<Ingredient> SeedIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient>()
            {
                new Ingredient()
                    {
                        Id = 1,
                        RecipeId = 1,
                        Name = "Chicken Legs",
                        MeassureUnitId = 3,
                        Quantity = 350
                    },

                    new Ingredient()
                    {
                        Id = 2,
                        RecipeId = 1,
                        Name = "Onion",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },

                    new Ingredient()
                    {
                        Id = 3,
                        RecipeId = 1,
                        Name = "Carrot",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },

                    new Ingredient()
                    {
                        Id = 4,
                        RecipeId = 1,
                        Name = "Celery stalk",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },

                    new Ingredient()
                    {
                        Id = 5,
                        RecipeId = 1,
                        Name = "Frozen Peas and Corn",
                        MeassureUnitId = 3,
                        Quantity = 150
                    },

                    new Ingredient()
                    {
                        Id = 6,
                        RecipeId = 1,
                        Name = "Fresh parsley",
                        MeassureUnitId = 3,
                        Quantity = 5
                    },

                    new Ingredient()
                    {
                        Id = 7,
                        RecipeId = 1,
                        Name = "Salt",
                        MeassureUnitId = 3,
                        Quantity = 5
                    },

                    new Ingredient()
                    {
                        Id = 8,
                        RecipeId = 2,
                        Name = "Lentil",
                        MeassureUnitId = 3,
                        Quantity = 250
                    },

                    new Ingredient()
                    {
                        Id = 9,
                        RecipeId = 2,
                        Name = "Potato",
                        MeassureUnitId = 3,
                        Quantity = 250
                    },

                    new Ingredient()
                    {
                        Id = 12,
                        RecipeId = 2,
                        Name = "Onion",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },

                    new Ingredient()
                    {
                        Id = 10,
                        RecipeId = 2,
                        Name = "Carrot",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },

                    new Ingredient()
                    {
                        Id = 11,
                        RecipeId = 2,
                        Name = "Celery Stalk",
                        MeassureUnitId = 3,
                        Quantity = 50
                    },
            };

            return ingredients;
        }
    }
}
