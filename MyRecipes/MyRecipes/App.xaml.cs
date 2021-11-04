using MyRecipes.Services;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRecipes
{
    public partial class App : Application
    {

        private static RecipesData recipesData;

        public static RecipesData RecipesData
        {
            get
            {
                if(recipesData == null)
                {
                    recipesData = new
                        RecipesData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Recipes.db3"));
                }
                return recipesData;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new  MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
