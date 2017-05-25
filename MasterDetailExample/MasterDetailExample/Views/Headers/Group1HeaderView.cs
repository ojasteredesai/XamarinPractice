using System;

using Xamarin.Forms;

namespace MasterDetailExample
{
	public class Group1HeaderView : Grid
	{
		public Label Title;

		public Group1HeaderView()
		{
			Title = new Label { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Start, TextColor = Color.Blue };

			Padding = new Thickness(20, 0, 0, 0);
			Children.Add(Title, 0, 0);
		}
	}
}