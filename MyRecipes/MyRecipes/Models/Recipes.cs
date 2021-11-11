using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyRecipes.Models
{
    public class Recipes
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string DihsesName { get; set; }
        public string CreatedBy { get; set; }
        public string Ingredients { get; set; }
        public string Steps { get; set; }
    }
}
