using Microsoft.EntityFrameworkCore.Metadata;
using System.ComponentModel.DataAnnotations;

namespace TestProjectForShareRecipies.Models.Recipe
{
    public class RecipeServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Picture { get; set; } = null!;

        public string? Description { get; set; }

        //Category, Ingredients, Author maybe must to added!!!
    }
}
