using MaratonaAvancada.Controls;
using MaratonaAvancada.iOS.Renderers;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircleImage), typeof(CircleImageRenderer))]
namespace MaratonaAvancada.iOS.Renderers
{
    class CircleImageRenderer : ImageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);

            var a = Control;

            if (Element != null)
                CreateCircle();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
                e.PropertyName == VisualElement.WidthProperty.PropertyName)
                CreateCircle();
        }

        private void CreateCircle()
        {
            try
            {
                var min = Math.Min(Element.Width, Element.Height);
                Control.Layer.CornerRadius = (float)(min / 2.0);
                Control.Layer.MasksToBounds = false;
                Control.BackgroundColor = Color.Transparent.ToUIColor();
                Control.ClipsToBounds = true;
            }
            catch (Exception ex)
            {
                Debug.Write("Unable to create circle image: " + ex);
            }
        }
    }
}