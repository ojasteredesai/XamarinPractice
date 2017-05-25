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
    public partial class XmalTapGestureFirstDemo : ContentPage
    {
        public XmalTapGestureFirstDemo()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), OnBoxViewLoad);
        }

        void OnBoxViewTapped(object sender, EventArgs args)
        {
            var bxView = sender as BoxView;
            Random random = new Random();
            bxView.Color = Color.FromRgb(255, random.Next(250), random.Next(240));
        }

        bool OnBoxViewLoad()
        {
            Random random = new Random();            
            this.Content.BackgroundColor = Color.FromRgb(random.Next(25), random.Next(250), random.Next(100));
            var childern = mainStack.Children;
            foreach (BoxView child in childern)
            {
                child.Color = Color.FromRgb(255, random.Next(175), random.Next(100));
            }
            mainStack.Children.Add(new BoxView { Color = Color.FromRgb(55, random.Next(115), random.Next(150)) });
            this.BackgroundColor = Color.FromRgb(random.Next(170,250), random.Next(180,220), random.Next(80,100));
            return true;
        }
    }
}
