using System;
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
            NavigateSuperlinkCommand = new DelegateCommand(NavigateSuperlink);
            NavigateCreateTabsCommand = new DelegateCommand(NavigateCreateTabs);
            NavigateOnPlatformCommand = new DelegateCommand(NavigateOnPlatform);

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
        public DelegateCommand NavigateSuperlinkCommand { get; }
        public DelegateCommand NavigateCreateTabsCommand { get; }
        public DelegateCommand NavigateOnPlatformCommand { get; }

        private void Navigate()
        {
            _navigationService.NavigateAsync("ViewA");
        }

        private void NavigateSuperlink()
        {
            _navigationService.NavigateAsync("EmptyTabbedPage?createTab=ViewA/ViewA?user=bart/ViewB?id=fromSuperlink");
        }

        private void NavigateCreateTabs()
        {
            //_navigationService.NavigateAsync("EmptyTabbedPage?createTab=TabA&createTab=TabB");
            _navigationService.NavigateAsync($"EmptyTabbedPage?{KnownNavigationParameters.CreateTab}=ViewA&{KnownNavigationParameters.CreateTab}=ViewB");
        }

        private void NavigateOnPlatform()
        {
            _navigationService.NavigateAsync("ViewC");
        }
    }
}
