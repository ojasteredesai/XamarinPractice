using System;

using Xamarin.Forms;

namespace MasterDetailExample.Models
{
	public class MenuOption
	{
		public MenuOption()
		{
		}

		public MenuOption(string option, Page page)
		{
			Option = option;
			OptionPage = page;
		}

		public string Option { get; set; }
		public Page OptionPage { get; set; }
		public string ImageSourceOption { get; set; } = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png";
	}
}