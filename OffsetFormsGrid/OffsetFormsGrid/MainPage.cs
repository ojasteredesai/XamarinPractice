using Xamarin.Forms;

namespace OffsetFormsGrid
{
    public class MainPage : ContentPage
    {

        double offsetValue = 60;

        public MainPage()
        {
            
            var gridLayout = new Grid
            {
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition{Width = GridLength.Star},
                    new ColumnDefinition{Width = GridLength.Star}
                }
            };
            
            for (int i = 0; i <= 15; i++)
            {
                if (i % 2 == 0)
                {
                    gridLayout.RowDefinitions.Add(new RowDefinition { Height = offsetValue });
                }
                else
                {
                    gridLayout.RowDefinitions.Add(new RowDefinition { Height = (App.ScreenWidth / 2) - offsetValue });
                }
            }

            //Left column tiles
            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Blue }
                                        , 0 // left - sets column
                                        , 1 //right - sets colspans (right - left)
                                        , 0 //top -- Sets Row
                                        , 3 // bottom -- Sets RowSpan bottom - top)
                                        );

            //practice ojas
            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Red }
                                     , 0 // left - sets column
                                     , 1 //right - sets colspans (right - left)
                                     , 3 //top -- Sets Row
                                     , 6 // bottom -- Sets RowSpan bottom - top)
                                     );
            
            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Yellow }
                                     , 0 // left - sets column
                                     , 1 //right - sets colspans (right - left)
                                     , 6 //top -- Sets Row
                                     , 9 // bottom -- Sets RowSpan bottom - top)
                                     );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Orange }
                                     , 0 // left - sets column
                                     , 1 //right - sets colspans (right - left)
                                     , 9 //top -- Sets Row
                                     , 11 // bottom -- Sets RowSpan bottom - top)
                                     );

            //Right column tiles


            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Aqua }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 0 //top -- Sets Row
                                        , 2 // bottom -- Sets RowSpan bottom - top)
                                        );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Accent }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 2 //top -- Sets Row
                                        , 4 // bottom -- Sets RowSpan bottom - top)
                                        );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Olive }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 4 //top -- Sets Row
                                        , 6 // bottom -- Sets RowSpan bottom - top)
                                        );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Pink }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 6 //top -- Sets Row
                                        , 8 // bottom -- Sets RowSpan bottom - top)
                                        );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Maroon }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 8 //top -- Sets Row
                                        , 10 // bottom -- Sets RowSpan bottom - top)
                                        );

            gridLayout.Children.Add(new ContentView
            { BackgroundColor = Color.Navy }
                                        , 1 // left - sets column
                                        , 2 //right - sets colspans (right - left)
                                        , 10 //top -- Sets Row
                                        , 12 // bottom -- Sets RowSpan bottom - top)
                                        );
            //practice ojas

            Content = new ScrollView
            {
                Content = gridLayout
            };
        }
    }
}
