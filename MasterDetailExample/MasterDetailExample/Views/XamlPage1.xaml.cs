using MasterDetailExample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamlPage1 : ContentPage
    {
        public XamlPage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XmalPage2());
        }
    }
}
