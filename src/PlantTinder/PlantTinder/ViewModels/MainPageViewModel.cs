using System;
using System.Collections.ObjectModel;
using System.Linq;
using PlantTinder.Models;
using PlantTinder.Services;

namespace PlantTinder.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private Plant _selectedPlant;
        public Plant SelectedPlant
        {
            get => _selectedPlant;

            set
            {
                _selectedPlant = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Plant> _plants;
        public ObservableCollection<Plant> Plants
        {
            get => _plants;

            set
            {
                _plants = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<PlantCategory> _categories;
        public ObservableCollection<PlantCategory> Categories
        {
            get => _categories;
            set
            {
                _categories = value;
                OnPropertyChanged();
            }
        }

        private PlantCategory LastItemSelected;

        private PlantCategory _categoryItemSelected;
        public PlantCategory CategoryItemSelected
        {
            get => _categoryItemSelected;
            set
            {
                if (LastItemSelected != null)
                {
                    LastItemSelected.IsSelected = false;
                }

                if(_categoryItemSelected != value)
                {
                    _categoryItemSelected = value;
                }
                

                if (_categoryItemSelected != null)
                {
                    _categoryItemSelected.IsSelected = true;
                    LastItemSelected = _categoryItemSelected;
                }

                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            LoadData();

            _categoryItemSelected = Categories.FirstOrDefault();
        }

        private void LoadData()
        {
            Plants = new ObservableCollection<Plant>(PlantService.Instance.GetPlants());
            Categories = new ObservableCollection<PlantCategory>(CategoryService.Instance.GetCategories());
        }
    }
}
