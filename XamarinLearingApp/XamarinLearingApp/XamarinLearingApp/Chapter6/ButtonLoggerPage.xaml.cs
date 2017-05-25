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
    public partial class ButtonLoggerPage : ContentPage
    {
        StackLayout loggerLayOut = new StackLayout();
        public ButtonLoggerPage()
        {
            InitializeComponent();
            Button btnClickMe = new Button
            {
                Text = "Click to Log the time"
            };

            btnClickMe.Clicked += btnClickMe_click;
            this.Padding = new Thickness(5, Device.OnPlatform(0, 20, 0), 5, 0);

            this.Content = new StackLayout
            {
                Children =
                {
                    btnClickMe,
                    new ScrollView
                    {
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        Content = loggerLayOut
                    }
                }
            };
        }

        void btnClickMe_click(object sender, EventArgs args)
        {
            // Add Label to scrollable StackLayout.
            loggerLayOut.Children.Add(new Label
            {
                Text = "Button clicked at " + DateTime.Now.ToString("T")
            });


        }
    }
}
