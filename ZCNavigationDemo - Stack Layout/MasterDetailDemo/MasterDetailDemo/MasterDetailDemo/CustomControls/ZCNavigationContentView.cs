using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MasterDetailDemo
{
    public class ZCNavigationContentView : ContentView
    {
        #region Private Variables
        List<ZCNavigationSource> dataSource;
        bool mFirstExpaned = false;
        StackLayout mainStackLayout;
        #endregion

        #region Properties
        public List<ZCNavigationSource> DataSource
        {
            get { return dataSource; }
            set { dataSource = value; }
        }
        public bool FirstExpaned
        {
            get { return mFirstExpaned; }
            set { mFirstExpaned = value; }
        }
        #endregion

        #region Constructors
        public ZCNavigationContentView()
        {
            var mainLayout = new StackLayout();
            Content = mainLayout;
        }
        public ZCNavigationContentView(List<ZCNavigationSource> source)
        {
            dataSource = source;
            DataBind();
        }
        #endregion

        #region  Public Methods
        public void DataBind()
        {
            //   var vMainLayout = new StackLayout { Padding = new Thickness(0, 2, 0, 2), HorizontalOptions = LayoutOptions.FillAndExpand };
            //  var vMainLayout = new StackLayout { Padding = new Thickness(0, 2, 0, 2), HorizontalOptions = LayoutOptions.FillAndExpand };
            var vMainLayout = new StackLayout { Padding = Device.OnPlatform<Thickness>(new Thickness(0, 0, 0, 0), new Thickness(0, 1, 0, 1), new Thickness(0)), HorizontalOptions = LayoutOptions.FillAndExpand, Spacing = 3 };
            var vFirst = true;
            if (dataSource != null)
            {
                foreach (var vSingleItem in dataSource)
                {

                    var vHeaderButton = new ZCAccordionItem()
                    {
                        Text = vSingleItem.HeaderText.PadLeft(vSingleItem.HeaderText.Length + 3),
                        TextColor = vSingleItem.HeaderTextColor,
                        BackgroundColor = vSingleItem.HeaderBackGroundColor,
                        VerticalTextAlignment = TextAlignment.Center,
                        HorizontalTextAlignment = TextAlignment.Start
                    };

                    var vAccordionContent = new ContentView()
                    {
                        Content = vSingleItem.ContentItems,
                        IsVisible = false
                    };
                    if (vFirst)
                    {
                        vHeaderButton.Expand = mFirstExpaned;
                        vAccordionContent.IsVisible = mFirstExpaned;
                        vFirst = false;
                    }
                    vHeaderButton.AssosiatedContent = vAccordionContent;
                    var tapGestureRecognizer = new TapGestureRecognizer();
                    tapGestureRecognizer.Tapped += OnAccordionButtonClicked;

                    vHeaderButton.GestureRecognizers.Add(tapGestureRecognizer);

                    vMainLayout.Children.Add(vHeaderButton);
                    vMainLayout.Children.Add(vAccordionContent);
                }
            }
            mainStackLayout = vMainLayout;
            Content = mainStackLayout;
        }
        #endregion

        #region Events
        void OnAccordionButtonClicked(object sender, EventArgs args)
        {
            foreach (var child in mainStackLayout.Children)
            {
                if (child.GetType() == typeof(ContentView))
                    child.IsVisible = false;
                if (child.GetType() == typeof(ZCAccordionItem))
                {
                    var vButton = (ZCAccordionItem)child;
                    vButton.Expand = false;
                }
            }
            var vSenderButton = (ZCAccordionItem)sender;

            if (vSenderButton.Expand)
            {
                vSenderButton.Expand = false;
            }
            else
            {
                vSenderButton.Expand = true;
            }

            vSenderButton.AssosiatedContent.IsVisible = vSenderButton.Expand;
        }
        #endregion
    }
}
