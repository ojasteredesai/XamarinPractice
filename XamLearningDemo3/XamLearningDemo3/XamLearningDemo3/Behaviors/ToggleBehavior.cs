using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamLearningDemo3.Behaviors
{
    public class ToggleBehavior : Behavior<View>
    {
        TapGestureRecognizer tapRecognizer;
        public static readonly BindableProperty IsToggledProperty =
        BindableProperty.Create<ToggleBehavior, bool>(tb => tb.IsToggled, false);

        //static readonly BindablePropertyKey IsToggledPropertyKey = BindableProperty.CreateReadOnly("IsToggled", typeof(bool), typeof(ToggleBehavior), false);

        //public static readonly BindableProperty IsToggledProperty = IsToggledPropertyKey.BindableProperty;
        public bool IsToggled
        {
            set { SetValue(IsToggledProperty, value); }
            get { return (bool)GetValue(IsToggledProperty); }
        }
        protected override void OnAttachedTo(View view)
        {
            base.OnAttachedTo(view);
            tapRecognizer = new TapGestureRecognizer();
            tapRecognizer.Tapped += OnTapped;
            view.GestureRecognizers.Add(tapRecognizer);
        }
        protected override void OnDetachingFrom(View view)
        {
            base.OnDetachingFrom(view);
            view.GestureRecognizers.Remove(tapRecognizer);
            tapRecognizer.Tapped -= OnTapped;
        }
        void OnTapped(object sender, EventArgs args)
        {
            IsToggled = !IsToggled;
        }
    }
}
