using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismFormsAutofac.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        public ViewAViewModel()
        {
            NavigateCommand = new DelegateCommand(Navigate);
        }

        private string _title = "View A";
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
