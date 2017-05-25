using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamLearningDemo3.Chapter17;
using XamLearningDemo3.Chapter19;
using XamLearningDemo3.Chapter20;
using XamLearningDemo3.Chapter23;
using XamLearningDemo3.GridListDemo;

namespace XamLearningDemo3
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
                case "SimpleGridDemoPage":
                    Navigation.PushAsync(new SimpleGridDemoPage());
                    break;
                case "EmployeeGridPage":
                    Navigation.PushAsync(new EmployeeGridPage());
                    break;
                case "ListViewWithGrid":
                    Navigation.PushAsync(new ListViewWithGrid());
                    break;
                case "ListViewWithGridCodePage":
                    Navigation.PushAsync(new ListViewWithGridCodePage());
                    break;
                case "CodeBindingPage":
                    Navigation.PushAsync(new CodeBindingPage()); 
                    break;
                case "CompareEmployeeGrid":
                    Navigation.PushAsync(new CompareEmployeeGrid());
                    break; 
                case "PickerDemoPage":
                    Navigation.PushAsync(new PickerDemoPage());
                    break; 
                case "PickerBindingPage":
                    Navigation.PushAsync(new PickerBindingPage());
                    break;
                case "EntryPopPage":
                    Navigation.PushAsync(new EntryPopPage()); 
                    break;
                case "StyledTriggersPage":
                    Navigation.PushAsync(new StyledTriggersPage());
                    break; 
                case "EntrySwellPage":
                    Navigation.PushAsync(new EntrySwellPage()); 
                    break;
                case "DataTriggerPage":                    
                    Navigation.PushAsync(new DataTriggerPage());
                    break;
                case "EventTriggerPage":
                    Navigation.PushAsync(new EventTriggerPage());
                    break;
                case "MultiTriggerPage":
                    Navigation.PushAsync(new MultiTriggerPage());
                    break; 
                case "BehaviorEntryValidationPage":
                    Navigation.PushAsync(new BehaviorEntryValidationPage());
                    break;
                case "EmailValidationDemo":
                    Navigation.PushAsync(new EmailValidationDemo());
                    break; 
                case "ToggleLabelPage":
                    Navigation.PushAsync(new ToggleLabelPage());
                    break;
                case "FormattedTextTogglePage":
                    Navigation.PushAsync(new FormattedTextTogglePage());
                    break;
                case "RadioLabelsPage":
                    Navigation.PushAsync(new RadioLabelsPage());
                    break;
                case "EntryFormPage":
                    Navigation.PushAsync(new EntryFormPage());
                    break; 
                case "AlertLambdasPage":
                    Navigation.PushAsync(new AlertLambdasPage());
                    break;
                case "TextFileTryoutPage":
                    Navigation.PushAsync(new TextFileTryoutPage());
                    break;
                default:
                    break; 
            }
        }        
    }    
}
