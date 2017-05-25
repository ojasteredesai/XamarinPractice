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
    public partial class CodeBindingPage : ContentPage
    {
        public CodeBindingPage()
        {
            InitializeComponent();
            BindingContext = new ListViewWithGridViewModel().Employees[0];

            Label lblName = new Label();
            lblName.SetBinding(Label.TextProperty,new Binding("Name"));
            
            Entry lblName1 = new Entry();
            lblName1.SetBinding(Entry.TextProperty, "Name");

            StackLayout st = new StackLayout();
            st.Children.Add(lblName);
            st.Children.Add(lblName1);

            this.Content = st;
        }
    }
}
