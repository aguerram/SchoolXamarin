using GAb.services;
using System;
using System.Collections.Generic;
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
		}

		//Login button
		private async void Button_Clicked(object sender, EventArgs e)
		{
        //    //Navigation.PushAsync(new HomeScreen());
        //}
			bool valid = false;
			String username = usernameEntry.Text;
			String password = passwordEntry.Text;
			valid = await loginService.checkCredentials(username, password);
			if(valid)
			{
				DisplayAlert("Success", "Welcome " + usernameEntry.Text, "Okay");
			}
			else
			{
				DisplayAlert("Login failed", "Username or password are incorrect", "Close");
				passwordEntry.Text = "";
			}
		}

        //Signup button
        private void Button_Clicked_1(object sender, EventArgs e)
		{
            Navigation.PushAsync(new RegisterScreen());
		}
	}
}