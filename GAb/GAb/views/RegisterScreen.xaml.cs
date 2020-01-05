using System;
using System.Collections.Generic;
using GAb.models;
using GAb.services;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class RegisterScreen : ContentPage
    {
        AuthService authService = new AuthService();
        public RegisterScreen()
        {
            InitializeComponent();
        }

        public void emptyInputs(Entry username,Entry password,Entry repassword)
        {
            username.Text = string.Empty;
            password.Text = string.Empty;
            retyped_password.Text = string.Empty;
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            bool valid = false;
            String usernameS = username.Text;
            String passwordS = password.Text;
            String retypedPasswordS = retyped_password.Text;
            if (usernameS==null || passwordS==null || retyped_password==null)
            {
                await DisplayAlert("Failed", "Please check your inputs!", "try again!");
                return;
            }
            if (!retypedPasswordS.Equals(passwordS))
            {
                await DisplayAlert("Failed", "Passwords don't match!","try again!");
                password.Text = string.Empty;
                retyped_password.Text = string.Empty;
                return;
            }
            valid = await authService.createTeacher(usernameS, passwordS);
            if (valid)
            {
                emptyInputs(username, password, retyped_password);
                await DisplayAlert("Success", "Please login to your account", "Okay");

                await Navigation.PushAsync(new LoginScreen());
            }
            else
            {
                await DisplayAlert("Failed", "A user with the same name already exists", "try again!");
                username.Text = string.Empty;
            }
        }
    }
}
