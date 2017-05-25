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
    public partial class TapGestureFirstDemo : ContentPage
    {
        public TapGestureFirstDemo()
        {
            InitializeComponent();

            BoxView boxView = new BoxView
            {
              Color =  Color.Red
            };

            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += OnBoxViewTapped;
            boxView.GestureRecognizers.Add(tapGesture);
            this.Content = boxView;
        }

        void OnBoxViewTapped(object sender, EventArgs args)
        {
            var bxView = sender as BoxView;
            Random random = new Random();
            bxView.Color = Color.FromRgb(255, random.Next(250), random.Next(240));
        }
    }
}
