using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLearingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimplestKeypadPage : ContentPage
    {
        Button backSpaceButton;
        Label digitLabel;

        public SimplestKeypadPage()
        {
            // Create a vertical stack for the entire keypad.
            StackLayout mainStackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
            digitLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.End
            };

            mainStackLayout.Children.Add(digitLabel);

            backSpaceButton = new Button
            {
                Text = "\u21E6",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                IsEnabled = false
            };

            backSpaceButton.Clicked += OnBackspaceButtonClicked;
            mainStackLayout.Children.Add(backSpaceButton);

            // Now do the 10 number keys.
            StackLayout rowStack = null;
            for (int num = 1; num <= 10; num++)
            {
                if ((num - 1) % 3 == 0)
                {
                    rowStack = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    
                    mainStackLayout.Children.Add(rowStack);
                }

                Button digitButton = new Button
                {
                    Text = (num % 10).ToString(),
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                    StyleId = (num % 10).ToString()
                };
                digitButton.Clicked += OnDigitButtonClicked;
                // For the zero button, expand to fill horizontally.
                if (num == 10)
                {
                    digitButton.HorizontalOptions = LayoutOptions.FillAndExpand;
                }

                rowStack.Children.Add(digitButton);
            }

            this.Content = mainStackLayout;

            App app = Application.Current as App;
            digitLabel.Text = app.DisplayLabelText;
            backSpaceButton.IsEnabled = digitLabel.Text != null &&
            digitLabel.Text.Length > 0;

        }
        void OnBackspaceButtonClicked(object sender, EventArgs args)
        {
            string text = digitLabel.Text;
            digitLabel.Text = text.Substring(0, text.Length - 1);
            backSpaceButton.IsEnabled = digitLabel.Text.Length > 0;

            // Save keypad text.
            App app = Application.Current as App;
            app.DisplayLabelText = digitLabel.Text;
        }

        void OnDigitButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            digitLabel.Text += (string)button.StyleId;
            backSpaceButton.IsEnabled = true;

            // Save keypad text.
            App app = Application.Current as App;
            app.DisplayLabelText = digitLabel.Text;
        }
    }
}
