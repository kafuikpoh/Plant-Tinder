using System;
using PlantTinder.Services;
using PlantTinder.ViewModels;
using PlantTinder.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlantTinder
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //get the main/base view
            var mainPage = new NavigationPage(new MainPage());

            //get the NavigationService from the dependency service
            var navService = DependencyService.Get<INavService>() as NavigationService;

            navService.XamarinFormsNav = mainPage.Navigation;

            //register mapping of viewmodels to views
            navService.RegisterViewMapping(typeof(MainPageViewModel), typeof(MainPage));
            navService.RegisterViewMapping(typeof(PlantDetailViewModel), typeof(PlantDetailPage));

            MainPage = mainPage;
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
