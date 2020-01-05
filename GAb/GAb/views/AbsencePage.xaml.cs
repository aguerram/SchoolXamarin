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
			Picker picker = (Picker)sender;
			Option option = (Option)picker.SelectedItem;
			Picker lPicker = (Picker)sender;
			Option lesson = (Option)lPicker.SelectedItem;

			if(option == null || lesson == null)
			{
				DisplayAlert("Failed", "Please select option and lesson","Try again");
				return;
			}
			foreach (StudentListItem itm in studentListViewModel.Students)
			{
				//absenceDAO.saveAsync(new StudentAbsence(new DateTime(), itm.s.ID, lesson.ID,));
			}
		}
		private void choiceChanges(object sender, EventArgs e)
		{
			Picker picker = (Picker)sender;
			Option option = (Option)picker.SelectedItem;
			studentListViewModel.selectByOption(option);
		}
	}
}