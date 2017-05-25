using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo2.Chapter16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpacityBindingCodePage : ContentPage
    {
        
        public OpacityBindingCodePage()
        {
            InitializeComponent();

            Label label = new Label
            {
                Text = "Opacity binding demo",
                FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label)),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
            };

            Slider slider = new Slider
            {
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            label.BindingContext = slider;

            label.SetBinding(Label.OpacityProperty,"Value");
            label.SetBinding(Label.TextProperty, "Value");
            
            // Construct the page. 
            Padding = new Thickness(10, 0);
            Content = new StackLayout
            {
                Children = { label, slider }
            };
        }
    }
}
