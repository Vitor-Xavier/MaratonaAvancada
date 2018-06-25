using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android.AppLinks;

namespace MaratonaAvancada.Droid
{
    [Activity(Label = "MaratonaAvancada", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
        DataScheme = "maratonaxamarinTst",
        DataHost = "maratonaxamarinTst.com.br",
        DataPathPrefix = "/",
        Categories = new [] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            //Xamarin Forms AppLinks
            //AndroidAppLinks.Init(this);
            LoadApplication(new App());

            MessagingCenter.Subscribe<Models.Message>(this, "SendMessage", message =>
            {
                SendToast(message.Text);
            });
        }

        private void SendToast(string text)
        {
            Toast.MakeText(this, text, ToastLength.Short).Show();
        }
    }
}

