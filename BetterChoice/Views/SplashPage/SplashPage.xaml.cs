using Xamarin.Forms;

namespace BetterChoiceShared.Views
{
	public partial class SplashPage : ContentPage
	{
		public SplashPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			this.FadeTo(1, 4000, Easing.SinOut);
		}
	}
}

