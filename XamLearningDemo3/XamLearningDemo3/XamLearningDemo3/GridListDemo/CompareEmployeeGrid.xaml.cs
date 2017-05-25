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
    public partial class CompareEmployeeGrid : ContentPage
    {
        double columnWidth = 0;
        double defaultWidth = (Device.Idiom == TargetIdiom.Phone) ? 150 : 180;
        double rowHeight = (Device.Idiom == TargetIdiom.Phone) ? 60 : 120;

        public CompareEmployeeGrid()
        {
            InitializeComponent();
            var data = new ListViewWithGridViewModel();
            int count = data.Employees.Count;
            if (Device.Idiom == TargetIdiom.Phone)
            {
                columnWidth = (count < 3) ? App.Current.MainPage.Width / count : defaultWidth;
            }
            else
            {
                if (App.Current.MainPage.Width > App.Current.MainPage.Height)
                {
                    columnWidth = (count < 5) ? App.Current.MainPage.Width / count : defaultWidth;
                }
                else
                {
                    columnWidth = (count < 4) ? App.Current.MainPage.Width / count : defaultWidth;
                }
            }

            for (int i = 0; i < count; i++)
            {
                ColumnDefinition col = new ColumnDefinition { Width = columnWidth };
                compareGrid.ColumnDefinitions.Add(col);
            }

            RowDefinitionCollection tempRowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition { Height = rowHeight },
                };

            compareGrid.RowDefinitions = tempRowDefinitions;

            for (int i = 0; i < count; i++)
            {
                var compareListView = new ListView
                {
                    ItemsSource = data.Employees
                };
                

                Grid.SetRow(compareListView, 0);
                Grid.SetColumn(compareListView, i);

                compareGrid.Children.Add(compareListView);
            }
        }
    }
}
