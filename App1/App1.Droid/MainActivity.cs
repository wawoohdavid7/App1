using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using App1.Core;
using Xamarin.Forms.Platform.Android;
using App1.Core;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);
         
            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(AutofacContainer.GetApplicationInstance(new App1Module()));

        }
    }
}

