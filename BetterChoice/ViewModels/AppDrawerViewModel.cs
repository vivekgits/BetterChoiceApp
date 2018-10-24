﻿using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using AppDrawerItems;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using BetterChoiceShared;

namespace ViewModels.ViewModels
{
	public class AppDrawerViewModel : BindableBase, INavigationAware
	{
		public IList<DrawerItem> DrawerItems { get; set; }

		public ICommand DrawerItemSelectedCommand { get; set; }

		readonly INavigationService _navigationService;

		public AppDrawerViewModel(INavigationService navigationService)
		{
			_navigationService = navigationService;

			DrawerItemSelectedCommand = new Command<DrawerItem>(async (item)=> await OnDrawerItemSelected(item));
		}

		async Task OnDrawerItemSelected(DrawerItem item)
		{
			await _navigationService.NavigateAsync($"{Screens.LeonaNavigationPage}/{item.ScreenNavigateTo}");
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (DrawerItems == null)
				DrawerItems = new List<DrawerItem>()
				{
					new DrawerItem
					{
						Text = "Home",
						Icon = "ic_home_black_24dp",
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					},
					new DrawerItem
					{
						Text = "Categories",
						Icon = "ic_subject_black_24dp",
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					},
					new DrawerItem
					{
						Text = "Today's Deals",
						Icon = "ic_trending_up_black_24dp",
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					},
					new DrawerItem
					{
						Text = "Your Orders",
						Icon = "ic_list_black_24dp",
						ShowSeparatorAfter = true,
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					},
					new DrawerItem
					{
						Text = "Customer Service",
						Icon = "ic_help_black_24dp",
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					},
					new DrawerItem
					{
						Text = "Settings",
						Icon = "ic_settings_black_24dp",
						ScreenNavigateTo = BetterChoiceShared.Screens.ProductListing
					}
				};
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
