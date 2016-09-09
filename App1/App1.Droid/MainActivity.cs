using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using App1.Shared;
using Xamarin.Forms.Platform.Android;

namespace App1.Droid
{
    [Activity(Label = "App1", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
   {
      //public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
      protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);
         
            global::Xamarin.Forms.Forms.Init(this, bundle);
         // AutofacContainer.Resolve<>
         //LoadApplication(new App(new DroidSetup()));
         LoadApplication(AutofacContainer.GetApplicationInstance());
        }
    }
}

