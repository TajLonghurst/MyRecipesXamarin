using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MyRecipes.Models;
using SQLite;

namespace MyRecipes.Services
{
    public class RecipesData
    {
        private readonly SQLiteAsyncConnection _RecipesData;

        public RecipesData(string DBPath)
        {
            _RecipesData = new SQLiteAsyncConnection(DBPath);
            _RecipesData.CreateTableAsync<Recipes>();
        }
        public Task<List<Recipes>> GetRecipe()
        {
            return _RecipesData.Table<Recipes>().ToListAsync();
        }
        public Task<List<Recipes>> GetRecipesAsync()
        {
            //Get all notes.
            return _RecipesData.Table<Recipes>().ToListAsync();
        }
        public Task<int> SaveRecipeToData(Recipes recipes)
        {
            return _RecipesData.InsertAsync(recipes);
        }

        public async Task<int> UpdateRecipesData(Recipes recipes)
        {
           return await _RecipesData.UpdateAsync(recipes);
        }

        public Task<int> DeleteRecipeAsync(Recipes recipes)
        {
            // Delete a note.
            return _RecipesData.DeleteAsync(recipes);
        }
    }
}

//THIS PAGE IS RESPONISBLE FOR ALL THE FUNCTIONS THAT ADD / DELETE / DIRECTION TO ID OF RECIPE AND CREATE THE DATABASE 