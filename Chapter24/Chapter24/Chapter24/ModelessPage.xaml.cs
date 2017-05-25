using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chapter24
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModelessPage : ContentPage
    {
        public ModelessPage()
        {
            Title = "Modeless Page";
            NavigationPage.SetHasBackButton(this, false);
            Button goBackButton = new Button
            {
                Text = "Back to Main",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            goBackButton.Clicked += async (sender, args) =>
            {
                await Navigation.PopAsync();
            };
            Content = goBackButton;

            MessagingCenter
        }
    }
}
