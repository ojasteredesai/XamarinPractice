using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinLearingApp
{
    public class AltEntry : Entry
    {
        public static readonly BindableProperty ZCMobileTextProperty =
            BindableProperty.Create("ZCMobileText",typeof(string),typeof(AltEntry),"",propertyChanged: OnTextWidthChanged);

        public string ZCMobileText
        {
            set { SetValue(ZCMobileTextProperty, value); }
            get { return (string)GetValue(ZCMobileTextProperty); }
        }
        static void OnTextWidthChanged(BindableObject bindable, object oldValue, object newValue)
        {
            ((AltEntry)bindable).OnTextWidthChanged((string)oldValue, (string)newValue);
        }

        void OnTextWidthChanged(string oldValue, string newValue)
        {
            SetEntryWidthRequest(newValue);
        }        void SetEntryWidthRequest(string text)
        {
            Text = !string.IsNullOrEmpty(text) ? text + text.Length : "No Data" ;
            BackgroundColor = Color.FromRgb(text.Length * 10,text.Length*25,text.Length*5);
            FontSize = text.Length / 2;
        }
    }
}
