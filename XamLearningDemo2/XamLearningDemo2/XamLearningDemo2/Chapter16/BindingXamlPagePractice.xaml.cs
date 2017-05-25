using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo2.Chapter16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingXamlPagePractice 
    {
        public static readonly BindableProperty PageContentProperty = BindableProperty.Create("PageContent",
           typeof(ContentPage), typeof(BindingXamlPagePractice), null, propertyChanged: (bindable, oldValue, newValue) =>
           {
               var control = (BindingXamlPagePractice)bindable;
               control.PageContainer.Content = ((ContentPage)newValue).Content;

           });
        public ContentPage PageContent
        {
            get { return (ContentPage)GetValue(PageContentProperty); }
            set { SetValue(PageContentProperty, value); }
        }

        public BindingXamlPagePractice()
        {
           
            InitializeComponent();

            TapGestureRecognizer tg = new TapGestureRecognizer();
            tg.Tapped += (sender, args) =>
            {
                var selectedLabel = sender as Label;
                if (selectedLabel.Text == "Page1")
                {
                    PageContent = new Page1();
                }
                else if (selectedLabel.Text == "Page2")
                {
                    PageContent = new Page2();
                }
                else if (selectedLabel.Text == "Page3")
                {
                    PageContent = new Page3();
                }
            };

            label1.GestureRecognizers.Add(tg);
            label2.GestureRecognizers.Add(tg);
            label3.GestureRecognizers.Add(tg);

            SetBinding(PageContentProperty, new Binding("PageContent", BindingMode.TwoWay));
        }
    }
}
