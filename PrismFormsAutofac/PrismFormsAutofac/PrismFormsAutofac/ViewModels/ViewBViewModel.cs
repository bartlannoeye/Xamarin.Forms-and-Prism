using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismFormsAutofac.ViewModels
{
    internal class ViewBViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewBViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand(Navigate);
        }

        private string _title = "View B";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        private void Navigate()
        {
        }
    }
}
