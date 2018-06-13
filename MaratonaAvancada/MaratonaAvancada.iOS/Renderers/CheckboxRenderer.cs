using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MaratonaAvancada.Controls;
using MaratonaAvancada.iOS.Renderers;
using SaturdayMP.XPlugins.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace MaratonaAvancada.iOS.Renderers
{
    public class CheckboxRenderer : ViewRenderer<Checkbox, BEMCheckBox>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var checkbox = new BEMCheckBox();
                ConfigStyle(checkbox);

                SetNativeControl(checkbox);
            }

            if (e.OldElement != null)
            {
                Control.ValueChanged -= OnValueChanged;
            }

            if (e.NewElement != null)
            {
                Control.On = e.NewElement.IsChecked;

                Control.ValueChanged += OnValueChanged;
            }
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            Element.IsChecked = Control.On;
        }

        private void ConfigStyle(BEMCheckBox checkbox)
        {
            var checkboxColor = Color.FromHex("#ED3941").ToUIColor();

            checkbox.BoxType = BEMBoxType.Square;
            checkbox.OnAnimationType = BEMAnimationType.Fill;
            checkbox.OffAnimationType = BEMAnimationType.Fill;
            checkbox.AnimationDuration = 0.25f;
            checkbox.OnFillColor = checkboxColor;
            checkbox.OnTintColor = checkboxColor;
            checkbox.OnCheckColor = Color.White.ToUIColor();
        }
    }
}