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
    public partial class LoginPage : ContentPage
    {
        public Entry txtUserName;
        public Entry txtPassowrd;
        public Label currentUser;
        public LoginPage()
        {
            InitializeComponent();
            App app = Application.Current as App;

            StackLayout mainStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = new Thickness(5)
            };

            StackLayout userNameStack = new StackLayout { Orientation = StackOrientation.Horizontal, VerticalOptions = LayoutOptions.CenterAndExpand };
            StackLayout passwordStack = new StackLayout { Orientation = StackOrientation.Horizontal, VerticalOptions = LayoutOptions.CenterAndExpand };
            StackLayout buttonsStack = new StackLayout { Orientation = StackOrientation.Horizontal, VerticalOptions = LayoutOptions.CenterAndExpand };

            currentUser = new Label
            {
                Text = !string.IsNullOrEmpty(app.InputUser) ? "Current User - " + app.InputUser : "Current User - ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            mainStack.Children.Add(currentUser);

            Label lblUserName = new Label
            {
                Text = "User Name : ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            userNameStack.Children.Add(lblUserName);

            txtUserName = new Entry
            {
                Placeholder = "Enter User Name",
                Text="ojast",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand               
            };

            userNameStack.Children.Add(txtUserName);

            Label lblPassword = new Label
            {
                Text = "Password : ",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            passwordStack.Children.Add(lblPassword);

            txtPassowrd = new Entry
            {
                Placeholder = "Enter Password",
                Text="password1",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            passwordStack.Children.Add(txtPassowrd);

            Button btnLogin = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Login",
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
            };

            btnLogin.Clicked += OnLoginButtonClick;

            Button btnLogout = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Logout",
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
            };

            btnLogout.Clicked += OnLogoutButtonClick;

            Button btnRememberMe = new Button
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Text = "Remember Me",
                BorderColor = Color.Blue,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
            };

            btnRememberMe.Clicked += OnRememberMeButtonClick;

            buttonsStack.Children.Add(btnLogin);
            buttonsStack.Children.Add(btnLogout);
            buttonsStack.Children.Add(btnRememberMe);

            mainStack.Children.Add(userNameStack);
            mainStack.Children.Add(passwordStack);
            mainStack.Children.Add(buttonsStack);
            this.Content = mainStack;
        }

        void OnLoginButtonClick(object sender, EventArgs e)
        {
            Dictionary<string, string> inputUser = new Dictionary<string, string>();
            inputUser.Add(txtUserName.Text, txtPassowrd.Text);
            //Application.Current.MainPage.DisplayAlert("Login", "Successfully Logged In!!", "Ok");
            App app = Application.Current as App;

            if (app.ValidUsers.ContainsKey(txtUserName.Text)
                && app.ValidUsers[txtUserName.Text] == txtPassowrd.Text)
            {
                app.InputUser = txtUserName.Text;
                //currentUser.Text += app.InputUser;
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Login Error", "Invalid Login Details!!", "Ok");
            }
        }

        void OnLogoutButtonClick(object sender, EventArgs e)
        {
            App app = Application.Current as App;
            app.InputUser = null;
            currentUser.Text = "Current User - ";
        }

        void OnRememberMeButtonClick(object sender, EventArgs e)
        {
            App app = Application.Current as App;
            app.RememberMe = true;
            app.InputUser = txtUserName.Text;
            currentUser.Text += app.InputUser;

        }
    }
}
