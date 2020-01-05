using GAb.dao;
using GAb.models;
using GAb.viewmodel;
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
	public partial class AbsencePage : ContentPage
	{
		StudentListViewModel studentListViewModel;
		StudentAbsenceDAO absenceDAO = new StudentAbsenceDAO();
		private Option currentOption = null;
		private Lesson currentLesson = null;
		public AbsencePage()
		{
			InitializeComponent();
			studentListViewModel = new StudentListViewModel();
			BindingContext = studentListViewModel;
		}

		//Student list checkbox changes
		private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{
			CheckBox box = (CheckBox)sender;
			var selectedStudentListItem = box.BindingContext as StudentListItem;
			selectedStudentListItem.check = box.IsChecked;
		}

		private void SaveAbsence(object sender, EventArgs e)
		{
			int absentStudent = 0;
			int totalSudents = 0;
			

			if(currentOption == null || currentLesson == null)
			{
				DisplayAlert("Failed", "Please select option and lesson","Try again");
				return;
			}
			foreach (StudentListItem itm in studentListViewModel.Students)
			{
				if (itm.s.optionID != currentOption.ID)
					continue;
				totalSudents++;
				if(itm.check)
				{
					absentStudent++;
				}
				absenceDAO.saveAsync(new StudentAbsence(new DateTime(), itm.s.ID, currentLesson.ID, itm.check));
			}
			DisplayAlert("Success", String.Format("There are {0} absent students of {1}",absentStudent,totalSudents),"Okay");
			Navigation.PushAsync(new HomeScreen());
  }
		private void choiceChanges(object sender, EventArgs e)
		{
			Picker picker = (Picker)sender;
			Option option = (Option)picker.SelectedItem;
			studentListViewModel.selectByOption(option);
			currentOption = option;
		}
		private void lessonChanges(object sender, EventArgs e)
		{
			Picker picker = (Picker)sender;
			Lesson lesson = (Lesson)picker.SelectedItem;
			currentLesson = lesson;
		}
	}
}