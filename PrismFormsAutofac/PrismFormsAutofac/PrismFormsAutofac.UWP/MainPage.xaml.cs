using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Autofac;
using Prism.Autofac;

namespace PrismFormsAutofac.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new PrismFormsAutofac.App());
        }
    }

    public class UwpInitializer : IPlatformInitializer
    {
        // Changed from 6.3 to 7 as we updated Autofac and container.Update became obsolete
        //public void RegisterTypes(IContainer container)
        //{

        //}

        public void RegisterTypes(ContainerBuilder container)
        {
            throw new NotImplementedException();
        }
    }

}
