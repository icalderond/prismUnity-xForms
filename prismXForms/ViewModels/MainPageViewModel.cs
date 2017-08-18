using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace prismXForms.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;
        public DelegateCommand OnNavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService) // has to be named correctly
        {
            _navigationService = navigationService;
            OnNavigateCommand = new DelegateCommand(async () => await GoNext());
        }

        async Task GoNext() => await _navigationService.NavigateAsync("SecondPage");


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
