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
    public partial class ButtonLambdasPageXaml : ContentPage
    {

        public double resultNumber { get; set; }

        public string message1 { get; set; }
        public string message2 { get; set; }
        public string message3 { get; set; }
        public string message4 { get; set; }

        public ButtonLambdasPageXaml()
        {
            InitializeComponent();
            resultNumber = 1;
            message1 = "This is message 1";
            message2 = "This is message 2";
            message3 = "This is message 3";
            message4 = "This is message 4";
            BindingContext = this;
        }

        public void OnButtonClick(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            if (button.Text.ToLower() == "double")
            {
                resultNumber *= 2;
            }
            else
            {
                resultNumber /= 2;
            }
        }
    }
}
