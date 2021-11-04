using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyRecipes.Models
{
    public class Recipes
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string DihsesName { get; set; }
        public string CreatedBy { get; set; }
        public string Ingredents { get; set; }
        public string Steps { get; set; }
    }
}
