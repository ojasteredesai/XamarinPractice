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
    public partial class XamlClockPage : ContentPage
    {
        bool StartSwitch = false;
        public XamlClockPage()
        {
            InitializeComponent();
        }

        bool OnTimerClick()
        {
            if (StartSwitch)
            {
                DateTime dt = DateTime.Now;
                timeLabel.Text = dt.ToString("T");
                dateLabel.Text = dt.ToString("D");
                return true;
            }
            else
            {
                return false;
            }
        }

        void OnStartClick(object sender, EventArgs e)
        {
            StartSwitch = true;
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerClick);
        }

        void OnStopClick(object sender, EventArgs e)
        {
            StartSwitch = false;
            Device.StartTimer(TimeSpan.FromSeconds(1), OnTimerClick);
        }
    }
}
