using System;

using Xamarin.Forms;

namespace MasterDetailExample
{
	public class Group2HeaderView : Grid
	{
		public Label Title;

		public Group2HeaderView()
		{
			Title = new Label { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.End, TextColor = Color.Red };

			Padding = new Thickness(0, 0, 20, 0);
			Children.Add(Title, 0, 0);
		}
	}
}