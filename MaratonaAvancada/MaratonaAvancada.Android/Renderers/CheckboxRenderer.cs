using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using ACheckbox = Android.Widget.CheckBox;
using Xamarin.Forms.Platform.Android;
using MaratonaAvancada.Controls;
using System.ComponentModel;
using Android.Widget;
using Xamarin.Forms;
using MaratonaAvancada.Droid.Renderers;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace MaratonaAvancada.Droid.Renderers
{
    public class CheckboxRenderer : ViewRenderer<Checkbox, ACheckbox>
    {
        public CheckboxRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var checkbox = new ACheckbox(Context);

                SetNativeControl(checkbox);
            }

            if (e.OldElement != null)
            {
                Control.CheckedChange -= OnCheckChange;
            }

            if (e.NewElement != null)
            {
                Control.Checked = Element.IsChecked;

                Control.CheckedChange += OnCheckChange;
            }
        }

        private void OnCheckChange(object sender, CompoundButton.CheckedChangeEventArgs e)
        {
            Element.IsChecked = Control.Checked;
        }
    }
}