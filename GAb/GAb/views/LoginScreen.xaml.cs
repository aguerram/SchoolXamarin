using GAb.models;
using GAb.services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GAb.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginScreen : ContentPage
	{
		private AuthService loginService = new AuthService();
		public LoginScreen()
		{
			InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }


        //Login button
        private async void Button_Clicked(object sender, EventArgs e)
		{
        //    //Navigation.PushAsync(new HomeScreen());
        //}
			bool valid = false;
			String username = usernameEntry.Text;
			String password = passwordEntry.Text;
            Debug.WriteLine(password);
			valid = await loginService.checkCredentials(username, password);
            Teacher teacher = await loginService.getCurrentTeacher(username, password);

			if(valid)
			{
                //DisplayAlert("Success", "Welcome " + usernameEntry.Text, "Okay");
                App.IsUserLoggedIn = true;
                App.currentTeacher = teacher;
                if (teacher != null)
                {
                    Debug.WriteLine("not null");
                    SharedPreferences.teacher = teacher;
                    SharedPreferences.isLoggedIn = true;
                }
                await Navigation.PushAsync(new HomeScreen());

            }
            else
			{
				await DisplayAlert("Login failed", "Username or password are incorrect", "Close");
				passwordEntry.Text = "";
                App.IsUserLoggedIn = false;

            }
        }

        //Signup button
        private void Button_Clicked_1(object sender, EventArgs e)
		{
            Navigation.PushAsync(new RegisterScreen());
		}
	}
}