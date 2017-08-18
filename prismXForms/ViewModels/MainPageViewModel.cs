using System;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace prismXForms.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService) // has to be named correctly
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
        }
    }
}
