using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GAb.views
{
    public partial class RegisterScreen : ContentPage
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }
        //Signup button
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("success", "Register", "Ok");
        }
    }
}
