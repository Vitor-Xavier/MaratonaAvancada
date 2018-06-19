using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MaratonaAvancada.iOS.Services;
using MaratonaAvancada.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformNameService))]
namespace MaratonaAvancada.iOS.Services
{
    public class PlatformNameService : IPlatformNameService
    {
        public string GetPlatformName()
        {
            return "iOS";
        }
    }
}