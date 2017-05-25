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
    public partial class TwoButtonsPage : ContentPage
    {
        Button addMessageButton, removeMessageButton;
        StackLayout loggerLayOut = new StackLayout();
        public TwoButtonsPage()
        {
            //InitializeComponent();

            addMessageButton = new Button
            {
                Text = "Add Message",
                HorizontalOptions = LayoutOptions.Center
            };

            addMessageButton.Clicked += OnMessageButtonClick;

            removeMessageButton = new Button
            {
                Text = "Remove Message",
                HorizontalOptions = LayoutOptions.Center,
                IsEnabled = false
            };

            removeMessageButton.Clicked += OnMessageButtonClick;

            this.Padding = new Thickness(5, Device.OnPlatform(20, 0, 0), 5, 0);

            this.Content = new StackLayout
            {
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children = { addMessageButton,removeMessageButton}
                    },
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Orientation=ScrollOrientation.Vertical,
                        Content = loggerLayOut
                    }
                }       
            };
        }

        void OnMessageButtonClick(object sender, EventArgs args)
        {
            Button button = (Button)sender;

            if (button == addMessageButton)
            {
                loggerLayOut.Children.Add(new Label
                {
                    Text = "Hello Logger !! Button clicked at " + DateTime.Now.ToString("T")
                });
            }
            else
            {
                // Remove topmost Label from StackLayout.
                loggerLayOut.Children.RemoveAt(0);
            }

            // Enable "Remove" button only if children are present.
            removeMessageButton.IsEnabled = loggerLayOut.Children.Count > 0;
        }
    }
}
