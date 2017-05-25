using System;

using Xamarin.Forms;

namespace MasterDetailExample.Pages
{
	public class Page3 : ContentPage
	{
		public Page3()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Page 3" }
				}
			};
		}
	}
}

