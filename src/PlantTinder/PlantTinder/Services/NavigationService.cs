using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using PlantTinder.Services;
using PlantTinder.ViewModels;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationService))]
namespace PlantTinder.Services
{
    public class NavigationService : INavService
    {
        public INavigation XamarinFormsNav { get; set; }

        readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();

        public void RegisterViewMapping(Type viewModel, Type view)
        {
            _map.Add(viewModel, view);
        }

        public NavigationService()
        {
        }


        public bool CanGoBack => XamarinFormsNav.NavigationStack != null &&
            XamarinFormsNav.NavigationStack.Count > 0;

        public event PropertyChangedEventHandler CanGoBackChanged;

        

        public async Task GoBack()
        {
            if (CanGoBack)
            {
                await XamarinFormsNav.PopAsync(true);
                OnCanGoBackChanged();
            }
        }

        public async Task NavigateTo<TVM>() where TVM : BaseViewModel
        {
            await NavigateToView(typeof(TVM));

            if (XamarinFormsNav.NavigationStack.Last().BindingContext is BaseViewModel)
            {
                ((BaseViewModel)XamarinFormsNav.NavigationStack.Last().BindingContext).Init();
            }
        }

        public async Task NavigateTo<TVM, TParameter>(TParameter parameter) where TVM : BaseViewModel
        {
            await NavigateToView(typeof(TVM));

            if (XamarinFormsNav.NavigationStack.Last().BindingContext is BaseViewModel<TParameter>)
            {
                ((BaseViewModel<TParameter>)XamarinFormsNav.NavigationStack.Last().BindingContext).Init(parameter);
            }
        }

        //public void ClearBackStack()
        //{
        //    throw new NotImplementedException();
        //}

        //public void NavigateToUri(Uri uri)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveLastView()
        //{
        //    throw new NotImplementedException();
        //}

        async Task NavigateToView(Type viewModelType)
        {
            if (!_map.TryGetValue(viewModelType, out Type viewType))
            {
                throw new ArgumentException("No view found in view mapping for" + viewModelType.FullName + ".");
            }

            //use reflection to get the ctor
            var ctor = viewType.GetTypeInfo()
                .DeclaredConstructors
                .FirstOrDefault(dc => !dc.GetParameters().Any());

            //invoke ctor as a page
            var view = ctor.Invoke(null) as Page;

            await XamarinFormsNav.PushAsync(view, true);
        }

        void OnCanGoBackChanged() => CanGoBackChanged?.Invoke(this, new PropertyChangedEventArgs("CanGoBack"));
    }
}
