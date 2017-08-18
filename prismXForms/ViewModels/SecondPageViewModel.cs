using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace prismXForms.ViewModels
{
    public class SecondPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        public SecondPageViewModel(INavigationService navigationService) // has to be named correctly
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
