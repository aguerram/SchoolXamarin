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
	public partial class SearchScreen : ContentPage
	{
		private SearchViewModel searchViewModel;
		private Option currentOption = null;
		private Lesson currentLesson = null;

		private StudentDAO studentDao;
		private StudentAbsenceDAO absenceDAO;

		public SearchScreen()
		{
			InitializeComponent();
			init();
		}
		public void init()
		{
			searchViewModel = new SearchViewModel();
			absenceDAO = new StudentAbsenceDAO();
			BindingContext = searchViewModel;

			studentDao = new StudentDAO();
		}
		private void choiceChanges(object sender, EventArgs e)
		{
			Picker picker = (Picker)sender;
			Option option = (Option)picker.SelectedItem;
			searchViewModel.selectByOption(option);
			currentOption = option;
		}
		private void lessonChanges(object sender, EventArgs e)
		{
			Picker picker = (Picker)sender;
			Lesson lesson = (Lesson)picker.SelectedItem;
			currentLesson = lesson;
		}

		//Search button
		private void Button_Clicked(object sender, EventArgs e)
		{
			if(currentLesson == null || currentOption == null)
			{
				DisplayAlert("Error", "Please select option and lesson","Try again");
			}
			else
			{
				search();
			}
		}

		private async void search()
		{
			var list = await studentDao.GetByNameAsync(nameEntry.Text.Trim().ToLower());
			List<StudentAbsenceRelated> finalList = new List<StudentAbsenceRelated>();
			if(list.Count > 0)
			{
				foreach(Student s in list)
				{
					var absenceList = await absenceDAO.getStudentAbsence(s.ID,currentLesson.ID);
					finalList.Add(new StudentAbsenceRelated(absenceList, s));
				}
				var screen = new SearchResultsScreen(finalList);
				Navigation.PushAsync(screen);
			}
			else
			{
				DisplayAlert("Warning", "No results found for " + nameEntry.Text, "Close");
			}
			
		}
	}
}