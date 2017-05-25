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
    public partial class MasterDetailContainerPage : ContentPage
    {
        public BindableProperty DetailProperty1 = BindableProperty.Create("Detail1",
           typeof(ContentPage), typeof(MasterDetailContainerPage),
           propertyChanged: (bindable, value, newValue) =>
           {
               var masterPage = (MasterDetailContainerPage)bindable;
               masterPage.DetailContainer1.Content = newValue != null ?
                   ((ContentPage)newValue).Content : null;
               if (masterPage.DetailContainer1.Content != null)
               {
                   masterPage.DetailContainer1.Content.BindingContext = newValue != null ? (newValue as Page).BindingContext : null;
               }

           });

        public BindableProperty DetailProperty2 = BindableProperty.Create("Detail2",
           typeof(ContentPage), typeof(MasterDetailContainerPage),
           propertyChanged: (bindable, value, newValue) =>
           {
               var masterPage = (MasterDetailContainerPage)bindable;
               masterPage.DetailContainer2.Content = newValue != null ?
                   ((ContentPage)newValue).Content : null;
               if (masterPage.DetailContainer2.Content != null)
               {
                   masterPage.DetailContainer2.Content.BindingContext = newValue != null ? (newValue as Page).BindingContext : null;
               }

           });

        public ContentPage Detail1
        {
            get { return (ContentPage)GetValue(DetailProperty1); }
            set { SetValue(DetailProperty1, value); }
        }

        public ContentPage Detail2
        {
            get { return (ContentPage)GetValue(DetailProperty2); }
            set { SetValue(DetailProperty2, value); }
        }
        public MasterDetailContainerPage()
        {
            InitializeComponent();
            App.DetailContainerPage = this;
            Detail1 = new XamlPage1();
        }
        public MasterDetailContainerPage(ContentPage page)
        {
            InitializeComponent();
            Detail2 = page;
        }
    }
}
