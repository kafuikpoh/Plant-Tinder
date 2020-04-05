using System;
using System.Collections.Generic;
using PlantTinder.Models;
using PlantTinder.ViewModels;
using Xamarin.Forms;

namespace PlantTinder.Views
{
    public partial class PlantDetailPage : ContentPage
    {
        public PlantDetailPage(Plant plant)
        {
            InitializeComponent();

            BindingContext = new PlantDetailViewModel(plant);
        }

        async void BackIcon_Tapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}