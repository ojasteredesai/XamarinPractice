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
    public partial class BaskervillesCountPage : ContentPage
    {
        public BaskervillesCountPage()
        {
            InitializeComponent();
            int wordCount = countedLabel.WordCount;
            wordCountLabel.Text = wordCount + " words";
        }



        void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.NewTextValue;
            countedLabel.Text = countedLabel.Text + text;
            wordCountLabel.Text = countedLabel.WordCount + " words";
        }
    }
}
