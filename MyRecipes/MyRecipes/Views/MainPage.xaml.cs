using MyRecipes.Models;
using MyRecipes.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyRecipes
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            MainListView.ItemsSource = await App.RecipesData.GetRecipe();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditPage(new Recipes()));

        }

        async void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                // Navigate to the NoteEntryPage, passing the ID as a query parameter.
                Recipes recipes = (Recipes)e.CurrentSelection.FirstOrDefault();

                await Navigation.PushAsync(new EditPage(recipes));

            }
        }
    }
}
