using System;
using PlantTinder.Models;
namespace PlantTinder.ViewModels
{
    public class PlantDetailViewModel : BaseViewModel
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

        public PlantDetailViewModel(Plant selectedPlant)
        {
            Plant = selectedPlant;
        }
    }
}
