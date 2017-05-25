﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo2.Chapter16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewDemoPage : ContentPage
    {
        public WebViewDemoPage()
        {
            InitializeComponent();
        }

        void OnEntryCompleted(object sender, EventArgs args)
        {
            webView.Source = ((Entry)sender).Text;
        }
        void OnGoBackClicked(object sender, EventArgs args)
        {
            webView.GoBack();
        }
        void OnGoForwardClicked(object sender, EventArgs args)
        {
            webView.GoForward();
        }
    }
}
