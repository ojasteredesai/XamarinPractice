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
    public partial class ResourceSharingPage : ContentPage
    {
        public ResourceSharingPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
            }
        }
    }
}
