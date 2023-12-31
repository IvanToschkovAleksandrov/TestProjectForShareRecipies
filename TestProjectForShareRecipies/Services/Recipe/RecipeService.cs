﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Data;
using System.Text.RegularExpressions;
using TestProjectForShareRecipies.Data;
using TestProjectForShareRecipies.Data.Entities;
using TestProjectForShareRecipies.Models.Rating;
using TestProjectForShareRecipies.Models.Recipe;

namespace TestProjectForShareRecipies.Services.Recipe
{
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext context;

        public RecipeService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<AllCategoriesModel>> AllCategoriesAsync()
        {
            return await context
                .Categories
                .Select(c => new AllCategoriesModel()
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await context.Categories.Select(c => c.Name).ToListAsync();
        }

        public async Task<IEnumerable<MeassureUnitsModel>> AllMeassureUnitsAsync()
        {
            return await context
                .MeassureUnits
                .Select(mu => new MeassureUnitsModel()
                {
                    Id = mu.Id,
                    Name = mu.Name
                })
                .ToListAsync();
        }

        public async Task<RecipeQueryServiceModel> AllRecipesAsync(
            string? category = null, 
            string? searchTerm = null, 
            RecipeSorting sorting = RecipeSorting.Newest,
            int currentPage = 1, 
            int recipePerPage = 1)
        {
            var recipesQuery = context.Recipes.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                recipesQuery = context.Recipes
                    .Where(r => r.Category.Name == category);
            }

            if (!string.IsNullOrEmpty(searchTerm))
            {
                recipesQuery = context.Recipes
                    .Include(r => r.Ingredients)
                    .Where(r => r.Name.ToLower().Contains(searchTerm.ToLower())
                    || (r.Description != null && r.Description.ToLower().Contains(searchTerm.ToLower()))
                    || r.Author.FirstName.ToLower().Contains(searchTerm.ToLower())
                    || r.Author.LastName.ToLower().Contains(searchTerm.ToLower())
                    || r.Ingredients.Any(i => i.Name.ToLower().Contains(searchTerm.ToLower())));
            }

            var sortedRecipesQuery = sorting switch
            {
                RecipeSorting.Alphabetically => recipesQuery.OrderBy(r => r.Name),
                RecipeSorting.MostRated => recipesQuery.OrderByDescending(r => r.Ratings.Average(rt => rt.Value)),
                _ => recipesQuery.OrderByDescending(r => r.Id)
            };

            var pagedRecipes = await sortedRecipesQuery
                .Include(r => r.Ratings)
                .Skip((currentPage - 1) * recipePerPage)
                .Take(recipePerPage)
                .Select(r => new RecipeServiceModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Description = r.Description,
                    Picture = r.Picture,
                    AverageRating = r.Ratings.Any() ? r.Ratings.Average(rt => rt.Value) : 0
                })
                .ToListAsync();

            int totalRecipes = await recipesQuery.CountAsync();

            return new RecipeQueryServiceModel()
            {
                Recipes = pagedRecipes,
                TotalRecipesCount = totalRecipes
            };

        }

        public async Task CreateAsync(RecipeFormModel model)
        {
            var recipe = new Data.Entities.Recipe()
            {
                Name = model.Name,
                Picture = model.Picture,
                Description = model.Description,
                CategoryId = model.CategoryId,
                AuthorId = model.AuthorId,
                Ingredients = await DeserializeIngredientsStringAsync(model.Ingredients)
            };

            await context.Recipes.AddAsync(recipe);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var recipe = await context.Recipes.Include(r => r.Ratings).FirstOrDefaultAsync(r => r.Id == id);

            if(recipe != null)
            {
                context.Ratings.RemoveRange(recipe.Ratings);
                context.Recipes.Remove(recipe);
                await context.SaveChangesAsync();
            }
            
        }

        public async Task EditRecipeAsync(RecipeFormModel model, int id)
        {
            var modelIngredients = await DeserializeIngredientsStringAsync(model.Ingredients);

            var recipe = await context.Recipes.FirstAsync(r => r.Id == id);

            recipe.Name = model.Name;
            recipe.Picture = model.Picture;
            recipe.Description = model.Description;
            recipe.CategoryId = model.CategoryId;
            recipe.Ingredients = modelIngredients;

            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistRecipeAsync(int id)
        {
            return await context.Recipes.AnyAsync(r => r.Id == id);
        }

        public async Task<Category> GetCategoryByNameAsync(string name)
        {
            return await context.Categories.FirstAsync(c => c.Name == name);
        }

        public async Task<bool> IsTheOwnerOfTheRecipe(int recipeId, string userId)
        {
            var recipe = await context.Recipes.FirstOrDefaultAsync(r => r.Id == recipeId);

            return recipe != null && recipe.AuthorId == userId;
        }

        public async Task<RecipeDetailsModel> RecipeDetailsByIdAsync(int id)
        {
            var model = await context.Recipes
                .Where(r => r.Id == id)
                .Include(r => r.Ratings)
                .Select(r => new RecipeDetailsModel()
                {
                    Id = r.Id,
                    Name = r.Name,
                    Picture = r.Picture,
                    Description = r.Description,
                    Author = string.Join(" ", new[] { r.Author.FirstName, r.Author.LastName } ),
                    Category = r.Category.Name,
                    AverrageRating = r.AverageRating,
                    Ratings = r.Ratings.Select(rt => new RatingsDetailsModel
                    {
                        Value = rt.Value,
                        Author = String.Join(" ", new[] {rt.User.FirstName, rt.User.LastName}),
                        Comment = rt.Comment ?? String.Empty,
                        CreateDate = rt.Timestamp
                    }),
                    Ingredients = r.Ingredients.Select(i => new IngredientDetailsModel()
                    {
                        Name = i.Name,
                        Quantity = i.Quantity,
                        MeassureUnit = i.MeassureUnit.Name,
                    })

                })
                .FirstAsync();
            return model;
        }

        private async Task<List<Ingredient>> DeserializeIngredientsStringAsync(string jsonIngredients)
        {
            var ingredients = new List<Ingredient>();

            string[] modelIngredients = JsonConvert.DeserializeObject<string[]>(jsonIngredients);

            foreach (string ingredientAsString in modelIngredients)
            {
                string result = ingredientAsString.Substring(0, ingredientAsString.Length - 6);
                var arrResult = result.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Stack<string> newStack = new Stack<string>();

                foreach (var item in arrResult)
                {
                    newStack.Push(item);
                }

                var meassureUnit = await context.MeassureUnits.FirstAsync(mu => mu.Name == newStack.Pop());
                var quantity = decimal.Parse(newStack.Pop());
                var name = string.Join(" ", newStack);

                var ingredient = new Ingredient()
                {
                    Name = name,
                    Quantity = quantity,
                    MeassureUnitId = meassureUnit.Id
                };

                ingredients.Add(ingredient);
            }

            return ingredients;
        }
    }
}
