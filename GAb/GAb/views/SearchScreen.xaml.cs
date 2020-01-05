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

		public SearchScreen()
		{
			InitializeComponent();
			init();
		}
		public void init()
		{
			searchViewModel = new SearchViewModel();
			BindingContext = searchViewModel;
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
	}
}