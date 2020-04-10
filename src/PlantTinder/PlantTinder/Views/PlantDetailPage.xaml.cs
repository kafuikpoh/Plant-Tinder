using System;
using System.Collections.Generic;
using PlantTinder.Models;
using PlantTinder.Services;
using PlantTinder.ViewModels;
using Xamarin.Forms;

namespace PlantTinder.Views
{
    public partial class PlantDetailPage : ContentPage
    {

        PlantDetailViewModel viewModel => BindingContext as PlantDetailViewModel;

        public PlantDetailPage()
        {
            InitializeComponent();

            BindingContext = new PlantDetailViewModel(DependencyService.Get<INavService>());
        }

        async void BackIcon_Tapped(Object sender, System.EventArgs e)
        {
            await Navigation.PopAsync();
        }

        
    }
}