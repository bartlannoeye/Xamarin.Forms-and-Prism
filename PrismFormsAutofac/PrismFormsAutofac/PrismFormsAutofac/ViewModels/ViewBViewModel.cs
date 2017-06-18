using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using PrismFormsAutofac.Events;

namespace PrismFormsAutofac.ViewModels
{
    internal class ViewBViewModel : BindableBase, INavigatedAware
    {
        private readonly INavigationService _navigationService;
        private readonly IEventAggregator _eventAggregator;

        public ViewBViewModel(INavigationService navigationService, IEventAggregator eventAggregator)
        {
            _navigationService = navigationService;
            _eventAggregator = eventAggregator;

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
            _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            _eventAggregator.GetEvent<MyEvent>().Publish("We were on View B");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("id"))
            {
                Title = $"ViewB: {parameters["id"]}";
            }
        }
    }
}
