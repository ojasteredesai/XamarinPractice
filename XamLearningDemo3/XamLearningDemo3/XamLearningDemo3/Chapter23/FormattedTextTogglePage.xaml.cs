using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamLearningDemo3.Behaviors;

namespace XamLearningDemo3.Chapter23
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormattedTextTogglePage : ContentPage
    {
        public FormattedTextTogglePage()
        {
            InitializeComponent();
        }
        void OnBehaviorPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            if (args.PropertyName == "IsToggled")
            {
                //eventLabel.Text = "IsToggled = " + ((ToggleBehavior)sender).IsToggled;
                //eventLabel.Opacity = 1;
              //  eventLabel.FadeTo(0, 1000);
            }
        }
    }
}
