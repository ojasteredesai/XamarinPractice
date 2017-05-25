using System;

using Xamarin.Forms;

using MasterDetailExample.ViewModels;

namespace MasterDetailExample
{
	public class App : Application
	{
		public static MasterViewModel ViewModel;

		public App()
		{
			var master = new MasterDetailPage();
			ViewModel = new MasterViewModel(master);

			master.Master = new MasterPage();
			master.BindingContext = ViewModel;
			master.SetBinding(MasterDetailPage.IsPresentedProperty, "MenuPresented", BindingMode.TwoWay);

			MainPage = master;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}