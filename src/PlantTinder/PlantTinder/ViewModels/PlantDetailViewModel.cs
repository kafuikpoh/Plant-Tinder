using System;
using PlantTinder.Models;
using PlantTinder.Services;
using Xamarin.Forms;

namespace PlantTinder.ViewModels
{
    public class PlantDetailViewModel : BaseViewModel<Plant>
    {
        Plant _plant;
        public Plant Plant
        {
            get => _plant;

            set
            {
                _plant = value;
                OnPropertyChanged();
            }
        }

        public PlantDetailViewModel(INavService navService) : base(navService)
        {
            //Plant = selectedPlant;
        }

        public override void Init(Plant parameter)
        {
            //base.Init();
            Plant = parameter;
        }

        public Command BackCommand => new Command(async () => await NavService.GoBack());
    }
}
