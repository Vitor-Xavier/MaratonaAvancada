using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MaratonaAvancada.Droid.Services;
using MaratonaAvancada.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformNameService))]
namespace MaratonaAvancada.Droid.Services
{
    public class PlatformNameService : IPlatformNameService
    {
        public string GetPlatformName()
        {
            return "Android";
        }
    }
}