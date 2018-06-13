using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MaratonaAvancada.Controls
{
    public class Checkbox : View
    {
        public BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(Checkbox), false);

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);
            set => SetValue(IsCheckedProperty, value);
        }
    }
}
