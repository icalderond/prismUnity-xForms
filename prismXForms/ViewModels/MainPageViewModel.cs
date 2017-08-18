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

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        public MainPageViewModel(INavigationService navigationService) // has to be named correctly
        {
            _navigationService = navigationService;
            OnNavigateCommand = new DelegateCommand(async () => await GoNext());
        }

        async Task GoNext() => await _navigationService
            .NavigateAsync(new Uri($"SecondPage?Title={Title}", UriKind.Relative));


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
