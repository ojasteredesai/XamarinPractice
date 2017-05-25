using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLearingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.StyleId)
            {
                case "loginpage":
                    Navigation.PushAsync(new LoginPage());
                    break;
                case "lamdapage":
                    Navigation.PushAsync(new ButtonLambdasPage());
                    break;
                case "lambdaspagexaml":
                    Navigation.PushAsync(new ButtonLambdasPageXaml());
                    break;
                case "loggerpage":
                    Navigation.PushAsync(new ButtonLoggerPage());
                    break;
                case "simplestkeypadpage":
                    Navigation.PushAsync(new SimplestKeypadPage());
                    break;
                case "FormattedTextPage":
                    Navigation.PushAsync(new FormattedTextPage());
                    break;
                case "ScaryColorListPage":
                    Navigation.PushAsync(new ScaryColorListPage());
                    break;
                case "SimplestKeypadPage":
                    Navigation.PushAsync(new SimplestKeypadPage());
                    break;
                case "FactoryMethodDemoPage":
                    Navigation.PushAsync(new FactoryMethodDemoPage());
                    break;
                case "ParameteredConstructorDemoPage":
                    Navigation.PushAsync(new ParameteredConstructorDemoPage());
                    break;
                case "XamlClockPage":
                    Navigation.PushAsync(new XamlClockPage());
                    break;
                case "PlatformSpecificLabelsPage":
                    Navigation.PushAsync(new PlatformSpecificLabelsPage());
                    break;
                case "ColorViewListPage":
                    Navigation.PushAsync(new ColorViewListPage());
                    break;
                case "XamlKeypadPage":
                    Navigation.PushAsync(new XamlKeypadPage());
                    break;
                case "TapGestureFirstDemo":
                    Navigation.PushAsync(new TapGestureFirstDemo());
                    break;
                case "XmalTapGestureFirstDemo":
                    Navigation.PushAsync(new XmalTapGestureFirstDemo());
                    break;
                case "LoginWebServicePage":
                    Navigation.PushAsync(new LoginWebServicePage());
                    break;
                case "SharedStaticsPage":
                    Navigation.PushAsync(new SharedStaticsPage());
                    break;
                case "SystemStaticsPage":
                    Navigation.PushAsync(new SystemStaticsPage());
                    break;
                case "ResourceSharingPage":
                    Navigation.PushAsync(new ResourceSharingPage());
                    break;
                case "ResourceTreesPage":
                    Navigation.PushAsync(new ResourceTreesPage());
                    break;
                case "DynamicVsStaticCodePage":
                    Navigation.PushAsync(new DynamicVsStaticCodePage());
                    break;
                case "TextBoxResizePage":
                    Navigation.PushAsync(new TextBoxResizePage());
                    break;
                case "BasicStylePage":
                    Navigation.PushAsync(new BasicStylePage());
                    break;
                case "StyleInheritancePage":
                    Navigation.PushAsync(new StyleInheritancePage());
                    break;
            }
        }
    }
}
