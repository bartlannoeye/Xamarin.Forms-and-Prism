using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace PrismFormsAutofac.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public ViewAViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new DelegateCommand(Navigate);
        }

        private string _title = "View A";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _myParameter;
        public string MyParameter
        {
            get => _myParameter;
            set => SetProperty(ref _myParameter, value);
        }

        public DelegateCommand NavigateCommand { get; private set; }

        private void Navigate()
        {
            var parameters = new NavigationParameters();
            parameters.Add("id", MyParameter);

            _navigationService.NavigateAsync("ViewB", parameters);
        }
    }
}
