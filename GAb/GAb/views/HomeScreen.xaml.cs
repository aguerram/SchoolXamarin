using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace GAb.views
{
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        
        private void NavigateToAddStudentScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddStudentScreen());
        }

    }

}
