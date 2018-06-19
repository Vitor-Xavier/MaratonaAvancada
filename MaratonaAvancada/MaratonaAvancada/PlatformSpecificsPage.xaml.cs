using MaratonaAvancada.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace MaratonaAvancada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlatformSpecificsPage : ContentPage
	{
		public PlatformSpecificsPage ()
		{
			InitializeComponent ();
            entry.Placeholder = DependencyService.Get<IPlatformNameService>().GetPlatformName();
		}

        private void buttonResize_Clicked(object sender, EventArgs e)
        {
            App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }

        private void buttonPan_Clicked(object sender, EventArgs e)
        {
            App.Current.On<Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Pan);
        }
    }
}