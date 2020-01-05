using System;
using System.Collections.Generic;
using System.Diagnostics;
using GAb.models;
using Xamarin.Forms;

namespace GAb.views
{
    public partial class HomeScreen : ContentPage
    {
        Teacher currentTeacher;
        public HomeScreen()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            Debug.WriteLine(SharedPreferences.teacher.username);
            currentTeacher = App.currentTeacher;
            teacherName.Text = String.Format("Welcome back Mr/Mrs {0}", currentTeacher.username);
        }



        private void NavigateToAddStudentScreen(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddStudentScreen());
        }
        private void Logout(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            App.currentTeacher = null;
            Navigation.PushAsync(new LoginScreen());
        }
        private void NavigatToAddNewLesson(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddNewLessonScreen());
        }
        private void NavigateToAbsenceScreen(object sender, EventArgs e)
		{
			Navigation.PushAsync(new AbsencePage());
		}
		private void NavigateToSearchScreen(object sender,EventArgs e)
		{
			Navigation.PushAsync(new SearchScreen());
		}
	}

}
