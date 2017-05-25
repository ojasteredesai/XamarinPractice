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
    public partial class FormattedTextPage : ContentPage
    {
        public FormattedTextPage()
        {
            InitializeComponent();
        }

        void OnButtonClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ParameteredConstructorDemoPage());
        }

        void OnButtonClickClock(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XamlClockPage());            
        }
    }
}
