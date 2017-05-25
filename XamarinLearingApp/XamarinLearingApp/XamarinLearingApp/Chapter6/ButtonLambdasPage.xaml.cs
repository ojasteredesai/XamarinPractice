using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonLambdasPage : ContentPage
    {
        Button doubleButton, halfButton;
       
        public ButtonLambdasPage()
        {
            double number = 1;
            //InitializeComponent();
            Label numberLabel = new Label
            {
                Text = number.ToString(),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            doubleButton = new Button
            {
                Text = "Double",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            doubleButton.Clicked += (sender, args) =>
            {
                number *= 2;
                numberLabel.Text = number.ToString();
            };

            halfButton = new Button
            {
                Text = "Half",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            halfButton.Clicked += (sender, args) =>
            {
                number /= 2;
                numberLabel.Text = number.ToString();
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    numberLabel,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            doubleButton,
                            halfButton,
                        }
                    },
                }
            };
        }
    }
}
