﻿using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PrismFormsAutofac.Droid
{
    [Activity(Label = "PrismFormsAutofac", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

