using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinLearingApp
{
    public partial class App : Application
    {
        public Dictionary<string, string> ValidUsers = new Dictionary<string, string>();
        const string displayLabelText = "displayLabelText";        const string inputUser = "inputUser";        const string rememberMe = "rememberMe";
        public string DisplayLabelText { set; get; }
        public string InputUser { set; get; }
        public bool RememberMe { set; get; }
        public App()
        {
            InitializeComponent();
            ValidUsers.Add("ojast", "password1");
            ValidUsers.Add("admin", "password2");

            if (Properties.ContainsKey(displayLabelText))
            {
                DisplayLabelText = (string)Properties[displayLabelText];
            }

            if (Properties.ContainsKey(inputUser))
            {
                InputUser = (string)Properties[inputUser];
            }

            //MainPage = new NavigationPage(new XamarinLearingApp.MainPage());
            MainPage = new NavigationPage(new XamarinLearingApp.LoginPage());            
           // MainPage = new XamarinLearingApp.XamlClockPage();
            //MainPage = new NavigationPage(new XamarinLearingApp.FormattedTextPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Properties[displayLabelText] = DisplayLabelText;
            if (RememberMe)
            {
                Properties[inputUser] = InputUser;
                RememberMe = false;
            }
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
