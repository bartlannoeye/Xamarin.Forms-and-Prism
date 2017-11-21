using Prism;
using Prism.AppModel;
using Prism.Autofac;
using PrismFormsAutofac.ViewModels;
using PrismFormsAutofac.Views;
using Xamarin.Forms;

namespace PrismFormsAutofac
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }



        protected override void RegisterTypes()
        {
            Builder.RegisterTypeForNavigation<NavigationPage>();
            Builder.RegisterTypeForNavigation<MainPage>();
            Builder.RegisterTypeForNavigation<ViewA>();
            Builder.RegisterTypeForNavigation<ViewB>();
            Builder.RegisterTypeForNavigation<EmptyTabbedPage>();
            Builder.RegisterTypeForNavigationOnPlatform<ViewC, ViewCViewModel>("ViewC",
                new Platform<ViewC_UWP>(RuntimePlatform.UWP));

        }
    }
}
