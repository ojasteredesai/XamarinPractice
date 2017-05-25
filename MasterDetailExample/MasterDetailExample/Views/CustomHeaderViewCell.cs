using System;

using Xamarin.Forms;

namespace MasterDetailExample.Views
{
	public class CustomHeaderViewCell : ViewCell
	{
		protected override void OnBindingContextChanged()
		{
			base.OnBindingContextChanged();

			var item = BindingContext as GroupedMenuOption;

			if (item != null)
			{
				switch (item.GroupName)
				{
					case "Group 1":
						var group1View = new Group1HeaderView();
						group1View.Title.Text = item.GroupName;

						View = group1View;
						View.BackgroundColor = Color.Red;
						break;
					case "Group 2":
						var group2View = new Group2HeaderView();
						group2View.Title.Text = item.GroupName;

						View = group2View;
						View.BackgroundColor = Color.Gray;
						break;
				}
			}
			else
			{
				//Define some default View
			}
		}
	}
}