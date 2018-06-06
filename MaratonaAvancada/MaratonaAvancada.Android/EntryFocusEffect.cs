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
using MaratonaAvancada.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(EntryFocusEffect), "EntryFocusEffect")]
namespace MaratonaAvancada.Droid
{
    public class EntryFocusEffect : PlatformEffect
    {
        private Android.Graphics.Color _color = Android.Graphics.Color.ParseColor("#efefef");

        protected override void OnAttached()
        {
            Control.SetBackgroundColor(_color);
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName.Equals("IsFocused"))
            {
                if (((Android.Graphics.Drawables.ColorDrawable) Control.Background).Color == _color)
                    Control.SetBackgroundColor(Android.Graphics.Color.ParseColor("#b7b7b7"));
                else
                    Control.SetBackgroundColor(_color);
            }
        }

        protected override void OnDetached() { }
    }
}