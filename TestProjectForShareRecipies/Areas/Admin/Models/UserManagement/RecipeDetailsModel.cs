﻿namespace TestProjectForShareRecipies.Areas.Admin.Models.UserManagement
{
    public class RecipeDetailsModel
    {
        public string Name { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public string Description { get; set; } = null!;
        public double Rating { get; set; }
    }
}
