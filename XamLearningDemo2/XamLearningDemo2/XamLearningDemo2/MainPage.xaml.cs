using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamLearningDemo2.Chapter12;
using XamLearningDemo2.Chapter14;
using XamLearningDemo2.Chapter15;
using XamLearningDemo2.Chapter16;

namespace XamLearningDemo2
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
                case "ImplicitStylePage":
                    Navigation.PushAsync(new ImplicitStylePage());
                    break;
                case "DynamicStylesPage":
                    Navigation.PushAsync(new DynamicStylesPage());
                    break;
                case "AbsoluteLayoutPluralSitePage":
                    Navigation.PushAsync(new AbsoluteLayoutPluralSitePage());
                    break;
                case "AbsoluteDemoCodePage":
                    Navigation.PushAsync(new AbsoluteDemoCodePage());
                    break;
                case "AbsoluteDemoXamlPage":
                    Navigation.PushAsync(new AbsoluteDemoXamlPage());
                    break;
                case "ChessboardFixedPage":
                    Navigation.PushAsync(new ChessboardFixedPage());
                    break;
                case "ChessboardDynamicPage":
                    Navigation.PushAsync(new ChessboardDynamicPage());
                    break;
                case "SimpleOverlayPage":
                    Navigation.PushAsync(new SimpleOverlayPage());
                    break; 
                case "SliderDemoPage":
                    Navigation.PushAsync(new SliderDemoPage());
                    break;
                case "RgbSlidersPage":
                    Navigation.PushAsync(new RgbSlidersPage());
                    break;
                case "SquareDesignerPage":
                    Navigation.PushAsync(new SquareDesignerPage());
                    break;
                case "StepperDemoPage":
                    Navigation.PushAsync(new StepperDemoPage());
                    break;
                case "OpacityBindingCodePage":
                    Navigation.PushAsync(new OpacityBindingCodePage());
                    break;
                case "BindingXamlPagePractice":
                    Navigation.PushAsync(new BindingXamlPagePractice());
                    break;
                case "OpacityBindingXamlPage":
                    Navigation.PushAsync(new OpacityBindingXamlPage());
                    break;
                case "WebViewDemoPage":
                    Navigation.PushAsync(new WebViewDemoPage());
                    break;
                case "BindingPathDemosPage":
                    Navigation.PushAsync(new BindingPathDemosPage());
                    break;
                default:
                    break; 
            }            
        }
    }    
}
