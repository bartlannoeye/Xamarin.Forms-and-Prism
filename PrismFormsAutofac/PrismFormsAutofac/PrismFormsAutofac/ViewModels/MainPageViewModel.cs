using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using PrismFormsAutofac.Events;

namespace PrismFormsAutofac.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            
            Title = "Hello from ViewModel";
            NavigateCommand = new DelegateCommand(Navigate).ObservesCanExecute(() => IsActive);
            eventAggregator.GetEvent<MyEvent>().Subscribe((s) => Title = s);
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        private void Navigate()
        {
            _navigationService.NavigateAsync("ViewA");
        }
    }
}
