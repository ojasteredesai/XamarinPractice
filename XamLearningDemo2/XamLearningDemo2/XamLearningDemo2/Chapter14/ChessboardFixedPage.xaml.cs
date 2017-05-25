﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo2.Chapter14
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChessboardFixedPage : ContentPage
    {
        public ChessboardFixedPage()
        {
            const double squareSize = 35;
            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromRgb(240, 220, 130),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    // Skip every other square.
                    if (((row ^ col) & 1) == 0)
                        continue;
                    BoxView boxView = new BoxView
                    {
                        Color = Color.FromRgb(0, 64, 0)
                    };
                    Rectangle rect = new Rectangle(col * squareSize,
                    row * squareSize,
                    squareSize, squareSize);
                    absoluteLayout.Children.Add(boxView, rect);
                }
            }
            this.Content = absoluteLayout;
        }
    }
}
