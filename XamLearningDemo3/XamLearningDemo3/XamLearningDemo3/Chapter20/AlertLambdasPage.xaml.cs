using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo3.Chapter20
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlertLambdasPage : ContentPage
    {
        public AlertLambdasPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option",
            "yes or ok", "no or cancel");
            task.ContinueWith((Task<bool> taskResult) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    label.Text = String.Format("Alert {0} button was pressed",
                    taskResult.Result ? "OK" : "Cancel");
                });
            });
            label.Text = "Alert is currently displayed";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Task<bool> task = DisplayAlert("Simple Alert", "Decide on an option", "yes or ok", "no or cancel");
            label.Text = "Alert is currently displayed";
            bool result = await DisplayAlert("Simple Alert", "Decide on an option", "yes or ok", "no or cancel"); ;
            label.Text = String.Format("Alert {0} button was pressed",
            result ? "OK" : "Cancel");
        }

        private  void Button_Clicked_1(object sender, EventArgs e)
        {
            label.Text = "Displaying alert box";
             DisplayAlert("Simple Alert", "Click 'dismiss' to dismiss", "dismiss");
            label.Text = "Alert has been dismissed";
        }
    }
}
