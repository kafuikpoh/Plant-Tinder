using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantTinder.Models;
using PlantTinder.Services;
using PlantTinder.ViewModels;
using PlantTinder.Views;
using Xamarin.Forms;

namespace PlantTinder
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel => BindingContext as MainPageViewModel;

        List<VisualElement> _pillContents = new List<VisualElement>();

        int selectedIndex = 0;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel(DependencyService.Get<INavService>());

            _pillContents.Add(HomePlantContent);
            _pillContents.Add(CactusContent);
            _pillContents.Add(FlowersContent);
        }

        async void CategoryView_SelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            var currentSelection = e.CurrentSelection.FirstOrDefault() as PlantCategory;

            var catIndex = viewModel.Categories.IndexOf(currentSelection);

            await ShowContent(catIndex);
        }

        async Task ShowContent(int catIndex)
        {
            if (catIndex == selectedIndex) return;

            //reveal contents
            await _pillContents[selectedIndex].FadeTo(0);
            _pillContents[selectedIndex].IsVisible = false;

            _pillContents[catIndex].IsVisible = true;
            _ = _pillContents[catIndex].FadeTo(1);

            selectedIndex = catIndex;
        }

        

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Initialize MainPageViewModel
            viewModel?.Init();
        }
    }
}
