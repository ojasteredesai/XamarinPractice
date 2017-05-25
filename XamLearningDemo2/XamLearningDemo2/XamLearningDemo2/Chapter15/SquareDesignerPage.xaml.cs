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
    public partial class SquareDesignerPage : ContentPage
    {
        public SquareDesignerPage()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (sender == heighSlider)
            {
                boxView.HeightRequest = heighSlider.Value*20;
                
            }
            else if (sender == widthSlider)
            {
                boxView.WidthRequest = widthSlider.Value/20;
            }

            //boxView.Color = Color.FromRgb((int)heighSlider.Value,
            //(int)widthSlider.Value,
            //(int)widthSlider.Value);
        }
    }
}
