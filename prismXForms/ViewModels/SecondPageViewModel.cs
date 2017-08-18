using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace prismXForms.ViewModels
{
    public class SecondPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _navigationService;

        private string _Title;
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Title"))
            {
                Title = parameters.GetValue<string>("Title");
            }
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
