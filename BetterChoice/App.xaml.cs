﻿using Prism.Unity;
using BetterChoiceShared.Views;
using Xamarin.Forms;
using Prism.Navigation;
using Microsoft.Practices.Unity;
using BetterChoiceShared.Views.Home;
using Like.ViewModels;
using ListingServices;
using ViewModels.ViewModels;
using Acr.UserDialogs;

namespace BetterChoiceShared
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();
             
			NavigationService.NavigateAsync($"{Screens.SplashPage}");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<MasterDetailContainer>();
			Container.RegisterTypeForNavigation<LeonaNavigationPage>();
			Container.RegisterTypeForNavigation<SplashPage>();
			Container.RegisterTypeForNavigation<LandingContentPage>();
			Container.RegisterTypeForNavigation<ProductListing>();
			Container.RegisterTypeForNavigation<ListingDetail>();
			Container.RegisterType<LikeViewModel>();
			Container.RegisterType<AppDrawerViewModel>();

			Container.RegisterType(typeof(ICache), typeof(AkavacheImpl));
			Container.RegisterType(typeof(IListingService), typeof(ListingService));
            Container.RegisterInstance(UserDialogs.Instance);

        }
	}
}