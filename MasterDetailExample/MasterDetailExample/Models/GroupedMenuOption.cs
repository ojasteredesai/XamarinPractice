using System;
using System.Collections.ObjectModel;
using MasterDetailExample.Models;

namespace MasterDetailExample
{
	public class GroupedMenuOption : ObservableCollection<MenuOption>
	{
		public GroupedMenuOption()
		{
		}

		public string GroupName { get; set; }
	}
}