using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaAvancada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StylesPage : ContentPage
	{
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public StylesPage ()
		{
			InitializeComponent ();
            BindingContext = this;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                Resources["requiredField"] = Resources["warningLabel"];
            }
        }
    }
}