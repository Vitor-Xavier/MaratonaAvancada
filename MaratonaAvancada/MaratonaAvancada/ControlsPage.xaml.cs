using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaAvancada
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ControlsPage : ContentPage
	{
        public ObservableCollection<Models.Person> Persons { get; set; }

        public ControlsPage()
		{
			InitializeComponent ();
            Persons = new ObservableCollection<Models.Person>();
            BindingContext = this;
            LoadData();
		}

        private void LoadData()
        {
            Persons.Add(new Models.Person
            {
                Name = "Pessoa 1",
                Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum gravida, erat vitae placerat elementum, diam magna malesuada neque, tristique varius dolor metus non lorem.",
                Avatar = "https://orig00.deviantart.net/3ce4/f/2015/207/d/0/steam_themed_smiley_face_avatar_by_yirktos-d92z52h.png"
            });
            Persons.Add(new Models.Person
            {
                Name = "Pessoa 2",
                Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum gravida, erat vitae placerat elementum, diam magna malesuada neque, tristique varius dolor metus non lorem. Pellentesque non volutpat dolor. Aenean tortor neque, tempor quis sem non, rhoncus semper velit. Pellentesque habitant.",
                Avatar = "https://orig00.deviantart.net/3ce4/f/2015/207/d/0/steam_themed_smiley_face_avatar_by_yirktos-d92z52h.png"
            });
            Persons.Add(new Models.Person
            {
                Name = "Pessoa 3",
                Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum gravida, erat vitae placerat elementum, diam magna malesuada neque, tristique varius dolor metus non lorem. Pellentesque non volutpat dolor.",
                Avatar = "https://orig00.deviantart.net/3ce4/f/2015/207/d/0/steam_themed_smiley_face_avatar_by_yirktos-d92z52h.png"
            });
        }
	}
}