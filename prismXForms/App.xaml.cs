using Prism.Unity;
using prismXForms.ViewModels;
using prismXForms.Views;
using Xamarin.Forms;

namespace prismXForms
{
    public partial class App : PrismApplication
    {
        //public App(IPlatformInitializer initializer = null) : base(initializer)
        //{
        //}
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }
        protected override void RegisterTypes()
        {
            /* Container.RegisterTypeForNavigation<MainPage>();
			 * Container.RegisterTypeForNavigation<MainPage,MainPageViewModel>();
             *
             * Is important to know that the first option is faster 
             * than the second one. Since the second one uses reflection 
             * to get the ViewModel that needs to be associated with the Page.
            */
            Container.RegisterTypeForNavigation<MainPage, MainPageViewModel>();
            Container.RegisterTypeForNavigation<SecondPage, SecondPageViewModel>();
        }
    }
}