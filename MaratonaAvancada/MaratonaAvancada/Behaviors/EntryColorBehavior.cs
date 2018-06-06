using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MaratonaAvancada.Behaviors
{
    class EntryColorBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += TextChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= TextChanged;
            base.OnDetachingFrom(bindable);
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;

            if (string.IsNullOrWhiteSpace(entry.Text)) return;

            if (entry.Text.Length <= 8)
                entry.TextColor = Color.FromHex("#ff5656");
            else
                entry.TextColor = Color.FromHex("#B3000000");
        }
    }
}
