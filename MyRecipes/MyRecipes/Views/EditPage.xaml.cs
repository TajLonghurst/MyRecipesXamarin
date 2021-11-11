using MyRecipes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRecipes.Views
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditPage : ContentPage
    {

        public EditPage(Recipes recipes)
        {
            InitializeComponent();
            BindingContext = recipes;

            recipe = recipes;
        }

        public Recipes recipe { get; set; }


        async void SavedBtnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                recipe.DihsesName = Name.Text;
                recipe.CreatedBy = CreatedBy.Text;
                recipe.Steps = CookingSteps.Text;
                recipe.Ingredients = Ingredients.Text;

            }

            if(recipe.ID > 0)
            {  
                Updates();
            }
            else
            {
                Save();
            }

            await Navigation.PopAsync();
        }

        public async void Updates()
        {
            await App.RecipesData.UpdateRecipesData(recipe);
        }

        public async void Save()
        {
            await App.RecipesData.SaveRecipeToData(recipe);
        }
        

        async void DeleteBtnClicked(object sender, EventArgs e)
        {
            await App.RecipesData.DeleteRecipeAsync(recipe);

            //Leaves page, As when deleting the page there's not point staying
            await Navigation.PopAsync();

        }
    }
}