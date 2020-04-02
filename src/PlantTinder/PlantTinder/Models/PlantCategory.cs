using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlantTinder.Models
{
    public class PlantCategory : INotifyPropertyChanged
    {
        public string CategoryName { get; set; }

        string _iconImageSource;
        public string IconImageSource
        {
            get => _iconImageSource;
            set
            {
                _iconImageSource = value;
                OnPropertyChanged();
            }
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
