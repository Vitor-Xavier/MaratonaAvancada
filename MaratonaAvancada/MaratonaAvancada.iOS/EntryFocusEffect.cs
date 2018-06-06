using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using MaratonaAvancada.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("MyEffects")]
[assembly: ExportEffect(typeof(EntryFocusEffect), "EntryFocusEffect")]
namespace MaratonaAvancada.iOS
{
    class EntryFocusEffect : PlatformEffect
    {
        private readonly UIColor _color = UIColor.FromRGB(239, 239, 239);

        protected override void OnAttached()
        {
            Control.BackgroundColor = _color;
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);

            if (args.PropertyName.Equals("IsFocused"))
            {
                if (Control.BackgroundColor == _color)
                    Control.BackgroundColor = UIColor.FromRGB(183, 183, 183);
                else
                    Control.BackgroundColor = _color;
            }
        }

        protected override void OnDetached() { }
    }
}