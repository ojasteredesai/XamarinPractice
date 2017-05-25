using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo2.Chapter15
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepperDemoPage : ContentPage
    {
        public StepperDemoPage()
        {
            InitializeComponent();

            OnStepperValueChanged(stepper, null);
        }
        void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {
            Stepper stepper = (Stepper)sender;
            button.BorderWidth = stepper.Value;
            label.Text = stepper.Value.ToString("F0");
        }
    }
 }
