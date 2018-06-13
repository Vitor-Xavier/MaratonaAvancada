using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaAvancada.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemListView : ContentView
	{
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), 
            typeof(string), 
            typeof(ItemListView), 
            string.Empty);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(nameof(Description),
            typeof(string),
            typeof(ItemListView),
            string.Empty);

        public string Description
        {
            get => (string)GetValue(DescriptionProperty);
            set => SetValue(DescriptionProperty, value);
        }

        public static readonly BindableProperty MaxLengthProperty = BindableProperty.Create(nameof(MaxLength),
            typeof(int),
            typeof(ItemListView),
            200);

        public int MaxLength
        {
            get => (int)GetValue(MaxLengthProperty);
            set => SetValue(MaxLengthProperty, value);
        }

        public static readonly BindableProperty AvatarSourceProperty = BindableProperty.Create(nameof(AvatarSource),
            typeof(string),
            typeof(ItemListView),
            string.Empty);

        public string AvatarSource
        {
            get => (string)GetValue(AvatarSourceProperty);
            set => SetValue(AvatarSourceProperty, value);
        }

        public ItemListView ()
		{
			InitializeComponent ();
		}
	}
}