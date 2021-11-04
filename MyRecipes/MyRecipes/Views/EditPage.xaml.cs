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
        public EditPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                await App.RecipesData.SavePersonAsync(new Recipes
                {
                    DihsesName = Name.Text,
                    CreatedBy = CreatedBy.Text,
                    Steps = CookingSteps.Text,
                    Ingredents = Ingredients.Text
                }) ;

                Name.Text = string.Empty;
                CreatedBy.Text = string.Empty;
                CookingSteps.Text = string.Empty;
                Ingredients.Text = string.Empty;
            }
        }

    }
}