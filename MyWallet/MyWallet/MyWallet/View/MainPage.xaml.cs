using MyWallet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyWallet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var addCardViewModel = new AddCardViewModel();
            addCardViewModel.Navigation = Navigation;
            BindingContext = addCardViewModel;
        }
    }
}
