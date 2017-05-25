using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailExample
{
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();

			BindingContext = App.ViewModel;
		}
	}
}
