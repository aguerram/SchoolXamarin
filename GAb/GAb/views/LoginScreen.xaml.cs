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
		public LoginScreen()
		{
			InitializeComponent();
		}

		//Login button
		private void Button_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("success", "sds","Ok");
		}

		//Signup button
		private void Button_Clicked_1(object sender, EventArgs e)
		{

		}
	}
}