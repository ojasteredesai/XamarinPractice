using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using MasterDetailExample.Models;
using MasterDetailExample.Pages;

namespace MasterDetailExample.ViewModels
{
	public class MasterViewModel : BaseViewModel
	{
		public MasterViewModel(MasterDetailPage masterPage)
		{
			masterDetailPage = masterPage;

			var firstGroup = new GroupedMenuOption() { GroupName = "Group 1" };
			firstGroup.Add(new MenuOption("Option 1", new NavigationPage(new Page1())));
			firstGroup.Add(new MenuOption("Option 2", new NavigationPage(new Page2())));
			firstGroup.Add(new MenuOption("Option 3", new NavigationPage(new Page3())));
			var secondGroup = new GroupedMenuOption() { GroupName = "Group 2" };
			secondGroup.Add(new MenuOption("Option 1", new NavigationPage(new Page1())));
			secondGroup.Add(new MenuOption("Option 2", new NavigationPage(new Page2())));
			secondGroup.Add(new MenuOption("Option 3", new NavigationPage(new Page3())));

			MenuOptions.Add(firstGroup);
			MenuOptions.Add(secondGroup);

			masterDetailPage.Detail = MenuOptions[0][0].OptionPage;
		}

		bool menuPresented;
		MenuOption selectedMenuOption;
		MasterDetailPage masterDetailPage;

		public MenuOption SelectedMenuOption
		{
			get { return selectedMenuOption; }
			set
			{
				selectedMenuOption = value;
				OnPropertyChanged();

				if (selectedMenuOption != null)
					handleNavigation();
			}
		}

		public bool MenuPresented
		{
			get { return menuPresented; }
			set
			{
				menuPresented = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<GroupedMenuOption> MenuOptions { get; set; } = new ObservableCollection<GroupedMenuOption>();

		void handleNavigation()
		{
			masterDetailPage.Detail = SelectedMenuOption.OptionPage;

			SelectedMenuOption = null;
			MenuPresented = false;
		}
	}
}