using System;
using System.Collections.Generic;
using GAb.models;
using GAb.views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GAb
{
    public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }
        public static Teacher currentTeacher { get; set; }
        public HomeScreen homeScreen { get; set; }

		public App()
		{
			InitializeComponent();

            VerifyLogin();
     
		}

        public void VerifyLogin()
        {
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
