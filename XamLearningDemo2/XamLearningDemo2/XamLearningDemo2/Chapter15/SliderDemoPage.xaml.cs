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
    public partial class SliderDemoPage : ContentPage
    {
        public SliderDemoPage()
        {
            InitializeComponent();
            //Slider_ValueChanged(null, new ValueChangedEventArgs(0, 5));
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            double StepValue = 1;
            var oldVal = e.OldValue;// * 10000;
            var newVal = e.NewValue;// * 10000;
            var slider = sender as Slider;
            builder.AppendLine("Old Value is : " + string.Format("{0:F2}", oldVal));
            builder.AppendLine("New Value is : " + string.Format("{0:F2}", newVal));
            builder.AppendLine("Difference is : " + string.Format("{0:F2}", newVal - oldVal));
            label.Text = String.Format("Slider = {0}", builder.ToString());

            slider.Value = Math.Round(e.NewValue / StepValue)* StepValue; 
        }
    }
}
