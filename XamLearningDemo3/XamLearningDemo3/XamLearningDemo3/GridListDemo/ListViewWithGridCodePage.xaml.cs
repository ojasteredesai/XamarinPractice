using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo3.GridListDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewWithGridCodePage : ContentPage
    {
        public ListViewWithGridCodePage()
        {
            InitializeComponent();

            BindingContext = new ListViewWithGridViewModel();
        }
    }
}
