using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstPrismUnityApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title = "My First Prism App";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = Title + " " +(string)parameters["title"] + " and Prism";
        }
    }
}
