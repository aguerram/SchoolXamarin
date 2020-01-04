using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GAb
{
    public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }
        public App()
		{
			InitializeComponent();
            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new views.LoginScreen());
            }
            else
            {
                MainPage = new NavigationPage(new views.HomeScreen());
            }
        
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
