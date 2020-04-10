using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PlantTinder.Services;

namespace PlantTinder.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected INavService NavService { get; private set; }

        protected BaseViewModel(INavService navService)
        {
            NavService = navService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Init()
        {

        }
    }

    public class BaseViewModel<TParameter> : BaseViewModel
    {
        protected BaseViewModel(INavService navService) : base(navService)
        {

        }

        public override void Init()
        {
            //base.Init();

            Init(default(TParameter));
        }

        public virtual void Init(TParameter parameter)
        {

        }
    }
}
