using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter24
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            Title = "Main Page";
            Button gotoModelessButton = new Button
            {
                Text = "Go to Modeless Page",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            gotoModelessButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new ModelessPage());
            };
            Button gotoModalButton = new Button
            {
                Text = "Go to Modal Page",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            gotoModalButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushModalAsync(new ModalPage());
            };
            Content = new StackLayout
            {
                Children =
                         {
                         gotoModelessButton,
                         gotoModalButton
                         }
            };
        }

    }
}
