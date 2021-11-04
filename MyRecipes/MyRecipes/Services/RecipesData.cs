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
        public Task<List<Recipes>> GetPeopleAsync()
        {
            return _RecipesData.Table<Recipes>().ToListAsync();
        }
        public Task<int> SavePersonAsync(Recipes recipes)
        {
            return _RecipesData.InsertAsync(recipes);
        }
    }
}
