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
    public partial class XmalPage2 : ContentPage
    {
        public XmalPage2()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XmalPage3());
        }
    }
}
