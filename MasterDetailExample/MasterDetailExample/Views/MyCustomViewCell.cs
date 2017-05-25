using System;

using Xamarin.Forms;
using MasterDetailExample.Models;

namespace MasterDetailExample.Views
{
	public class MyCustomViewCell : ViewCell
	{
		Label nameLabel = new Label { Text = "This is it" };
		public MyCustomViewCell()
		{
			View = nameLabel;
		}

		public static readonly BindableProperty TitleProperty = BindableProperty.Create("Title", typeof(string), typeof(MyCustomViewCell), "Error");

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}

		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var item = BindingContext as MenuOption;

			if (item != null)
				nameLabel.Text = item.Option;
		}
	}
}