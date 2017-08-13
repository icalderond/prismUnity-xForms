using Prism.Unity;
using Xamarin.Forms;

namespace prismXForms
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer)
        {
        }
        protected override void OnInitialized() => InitializeComponent();
        protected override void RegisterTypes()
        {
        }
    }
}