using MyWallet.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyWallet.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardListPage : ContentPage
    {
        public CardListPage()
        {
            InitializeComponent();
            var listCardViewModel = new ListSavedCardsViewModel();           
            BindingContext = listCardViewModel;
        }
    }
}
